using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XsltHelper
{
    public class Xslt
    {
        public static void GenerateFile(string xmlPath, string htmlOutputPath, string xsdPath)
        {
            XPathDocument myXPathDoc = new XPathDocument(xmlPath);
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(xsdPath);
            XmlTextWriter myWriter = new XmlTextWriter(htmlOutputPath, null);
            myXslTrans.Transform(myXPathDoc, null, myWriter);
        }
    }
}
