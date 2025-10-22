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
        private string _xmlPath;
        private readonly XmlDocument _xmlDocument;
        public XmlClass(string xmlpath)
        {
            _xmlPath = xmlpath;
            _xmlDocument = new XmlDocument();
        }

        public int GetXmlInt(string XorY)
        {
            int value = 0;
            LoadingXml();
            XmlNode? node = GetNode(XorY);
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
            LoadingXml();
            XmlNode? node = GetNode(nodefromXml); 
            if (node != null)
            {
                stringtoreturn = node.InnerText.Trim();
            }
            return stringtoreturn;
        }
        private void LoadingXml()
        {
            _xmlDocument.LoadXml(_xmlPath);
        }
        private XmlNode GetNode(string XorY)
        {
            XmlNode? node = _xmlDocument.DocumentElement.SelectSingleNode(XorY);
            return node;
        }
    }
}
