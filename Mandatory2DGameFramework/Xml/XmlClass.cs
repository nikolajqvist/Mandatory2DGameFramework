using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mandatory2DGameFramework.Xml
{
    public class XmlClass
    {
        private string _xmlPath = @"D:\Datamatikeruddannelse\FjerdeSemester\AvanceretProgrammering\OpbligatoriskOpgave\MandatoryOOAdvanceret\Mandatory2DGameFramework\Config\XMLFile1.xml";
        private XmlDocument _xmlDocument;
        public XmlClass()
        {
            _xmlDocument = new XmlDocument();
        }

        public int GetXmlInt(string XorY)
        {
            int value = 0;
            LoadingXml(_xmlDocument, _xmlPath);
            XmlNode? node = _xmlDocument.DocumentElement.SelectSingleNode(XorY);
            if (node != null)
            {
                string txtXorY = node.InnerText.Trim();
                value = Convert.ToInt32(txtXorY);
            }
            return value;
        }
        public string GetXmlString(string nodefromXml)
        {
            string stringtoreturn = null;
            LoadingXml(_xmlDocument, _xmlPath);
            XmlNode? node = _xmlDocument.DocumentElement.SelectSingleNode(nodefromXml);
            if (node != null)
            {
                stringtoreturn = node.InnerText.Trim();
            }
            return stringtoreturn;
        }
        private void LoadingXml(XmlDocument xmlDocument,  string xmlPath)
        {
            xmlDocument.LoadXml(xmlPath);
        }
    }
}
