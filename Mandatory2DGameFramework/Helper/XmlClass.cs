using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mandatory2DGameFramework.Xml
{
    /// <summary>
    /// Denne klasse henter attributer fra en fil
    /// </summary>
    public class XmlClass
    {
        private string _xmlPath;
        private readonly XmlDocument _xmlDocument;
        /// <summary>
        /// Konstruktøren af XmlClass
        /// </summary>
        public XmlClass()
        {
            _xmlPath = "C:\\Users\\nqvis\\Downloads\\Mandatory2DGameFramework\\Mandatory2DGameFramework\\Mandatory2DGameFramework\\Config\\XMLFile1.xml";
            _xmlDocument = new XmlDocument();
        }
        /// <summary>
        /// Henter en int og konverter det fra string hentes fra en fil.
        /// </summary>
        /// <param name="XorY"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Henter en string fra en fil.
        /// </summary>
        /// <param name="nodefromXml"></param>
        /// <returns></returns>
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
