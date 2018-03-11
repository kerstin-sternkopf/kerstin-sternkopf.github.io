using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using DataEditor.Core.Properties;
using System.Diagnostics;

namespace DataEditor.Core
{
    public class Offers
    {
        private static string rootDir = Settings.Default.RootPath;
        private static string pathImgDir = Path.Combine(rootDir, "img");
        private static string pathXml = Path.Combine(rootDir, @"data\march.xml");
        private static string pathHtml = Path.Combine(rootDir, @"index.html");
        private static string pathXslt = Path.Combine(rootDir, @"data\angebote.xslt");

        public static void ExecuteGit()
        {
            string gitCommand = "git";
            string gitAddArgument = @"add -A";
            string gitCommitArgument = @"commit ""Seitenupdate vom "+ DateTime.Now.ToLongTimeString() + @""" ";
            string gitPushArgument = @"push remote:remote";

            Process.Start(gitCommand, gitAddArgument);
            Process.Start(gitCommand, gitCommitArgument);
            Process.Start(gitCommand, gitPushArgument);
        }

        public static void GenerateFile()
        {
            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(pathXslt);
            myXslTrans.Transform(pathXml, pathHtml);
        }

        public static List<Offer> ParseByXDocument()
        {
            var res = new List<Offer>();
            var offers = new Offers();
            XDocument doc = XDocument.Load(pathXml);
            var decendants = doc.Descendants("offer").ToList();
            for (int i = 0; i < decendants.Count; i++)
            {
                var item = decendants[i];
                var offer = new Offer();

                offer.Name = item.Element("name").Value;
                offer.Price = item.Element("price").Value;
                offer.Saving = item.Element("saving")?.Value;
                offer.Volume = item.Element("volume")?.Value;
                offer.Dimensions = item.Element("dimensions")?.Value;
                offer.Extras = item.Element("extras")?.Value;
                offer.Starts = Convert.ToDateTime(item.Element("starts").Value, CultureInfo.GetCultureInfo("de-DE"));
                offer.Ends = Convert.ToDateTime(item.Element("ends").Value, CultureInfo.GetCultureInfo("de-DE"));
                offer.Parts = item.Element("parts")?.Value;
                var imgPath = Path.Combine(pathImgDir, (i + 1).ToString() + ".png");
                Image img;
                using (var bmpTemp = new Bitmap(imgPath))
                {
                    img = new Bitmap(bmpTemp);
                }

                offer.Img = img;
                res.Add(offer);
            }

            return res;
        }

        public static bool AreValid(List<Offer> list)
        {
            foreach (var item in list)
            {
                if (!item.IsValid)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Serialize(List<Offer> list)
        {
            var doc = new XDocument();
            var root = new XElement("offers");
            doc.Add(root);
            for (int i = 0; i < list.Count; i++)
            {
                var current = list[i];
                var offer = new XElement("offer");

                offer.Add(new XAttribute("number", i + 1));
                offer.Add(new XElement("name", current.Name));
                offer.Add(new XElement("starts", current.Starts.ToString(new CultureInfo("de-DE", false).DateTimeFormat.ShortDatePattern)));
                offer.Add(new XElement("ends", current.Ends.ToString(new CultureInfo("de-DE", false).DateTimeFormat.ShortDatePattern)));
                offer.Add(new XElement("price", current.Price));

                if (!string.IsNullOrWhiteSpace(current.Saving))
                {
                    offer.Add(new XElement("saving", current.Saving));
                }

                if (!string.IsNullOrWhiteSpace(current.Extras))
                {
                    offer.Add(new XElement("extras", current.Extras));
                }

                if (!string.IsNullOrWhiteSpace(current.Parts))
                {
                    offer.Add(new XElement("parts", current.Parts));
                }
                if (!string.IsNullOrWhiteSpace(current.Volume))
                {
                    offer.Add(new XElement("volume", current.Volume));
                }

                if (!string.IsNullOrWhiteSpace(current.Dimensions))
                {
                    offer.Add(new XElement("dimensions", current.Dimensions));
                }

                if (current.Img != null)
                {
                    var imgPath = Path.Combine(pathImgDir, (i + 1).ToString() + ".png");
                    current.Img.Save(imgPath, ImageFormat.Png);
                }

                root.Add(offer);
            }

            doc.Save(pathXml);
        }

    }
}
