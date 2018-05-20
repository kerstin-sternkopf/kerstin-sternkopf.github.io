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
using System.Windows.Forms;

namespace DataEditor.Core
{
    public class Offers
    {
        private static string pathImgDir = Path.Combine(Settings.Default.RootPath, "img");
        private static string pathXml = Path.Combine(Settings.Default.RootPath, @"data\march.xml");
        private static string pathHtml = Path.Combine(Settings.Default.RootPath, @"index.html");
        private static string pathXslt = Path.Combine(Settings.Default.RootPath, @"data\angebote.xslt");
        private static string pathGit = Path.Combine(Settings.Default.GitInstallDir, @"bin\git.exe");


        public static void ExecuteGit()
        {
            string gitCommand = "git";
            string gitAddArgument = @"add -A";
            string gitCommitArgument = @"commit ""Seitenupdate vom " + DateTime.Now.ToLongTimeString() + @""" ";
            string gitPushArgument = @"push remote:remote";

            Process.Start(gitCommand, gitAddArgument);
            Process.Start(gitCommand, gitCommitArgument);
            Process.Start(gitCommand, gitPushArgument);
        }

        public static void ExeGit()
        {
            ProcessStartInfo gitInfo = new ProcessStartInfo();
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.FileName = pathGit;

            Process gitProcess = new Process();
            gitInfo.UseShellExecute = false;
            gitInfo.Arguments = "add -A";
            gitInfo.WorkingDirectory = Settings.Default.RootPath;

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            var stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            var stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            gitProcess.WaitForExit();
            gitProcess.Close();


            Process gitProcessCommit = new Process();
            gitInfo.UseShellExecute = false;
            gitInfo.Arguments = @"commit -m ""Seitenupdate vom " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + @""" ";
            gitInfo.WorkingDirectory = Settings.Default.RootPath;

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            stderr_str += gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            stdout_str += gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            gitProcess.WaitForExit();
            gitProcess.Close();


            Process gitProcessPush = new Process();
            gitInfo.UseShellExecute = false;
            gitInfo.Arguments = @"push";
            gitInfo.WorkingDirectory = Settings.Default.RootPath;

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            stderr_str += gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            stdout_str += gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            gitProcess.WaitForExit();
            gitProcess.Close();

            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(stderr_str, EventLogEntryType.Information);
                eventLog.WriteEntry(stdout_str, EventLogEntryType.Information);
            }
        }

        public static void GenerateFile()
        {
            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(pathXslt);
            myXslTrans.Transform(pathXml, pathHtml);
        }

        public static List<Offer> ParseByXDocument()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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

                var imgPath = Path.Combine(pathImgDir, (i + 1).ToString() + ".png");
                current.Img.Save(imgPath, ImageFormat.Png);

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

                root.Add(offer);
            }

            doc.Save(pathXml);
        }

    }
}
