using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mandatory2DGameFramework.worlds
{
    public class World
    {
        //Skal flyttes til egen klasse.
        private string _xmlPath = @"C:\\Users\\nqvis\\Downloads\\Mandatory2DGameFramework\\Mandatory2DGameFramework\\Mandatory2DGameFramework\\Config\\XMLFile1.xml";
        private XmlDocument _xmlDocument;
        
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public string Difficulty { get; set; }
        // world objects
        private List<WorldObject> _worldObjects;
        // world creatures
        private List<Creature> _creatures;

        public World(string difficulty)
        {
            MaxX = GetAltitude("MaxX");
            MaxY = GetAltitude("MaxY");
            Difficulty = GetStringtitude(difficulty);
            _worldObjects = new List<WorldObject>();
            _creatures = new List<Creature>();            
            _xmlDocument = new XmlDocument();
        }
        //Skal flyttes til sin egen klasse.
        private int GetAltitude(string XorY)
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
        //Skal flyttes til egen klasse.
        private string GetStringtitude(string nodefromXml)
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
        //Skal flyttes til egen klasse.
        private void LoadingXml(XmlDocument xmlDocument,  string xmlPath)
        {
            xmlDocument.LoadXml(xmlPath);
        }
        public override string ToString()
        {
            return $"{{{nameof(MaxX)}={MaxX.ToString()}, {nameof(MaxY)}={MaxY.ToString()}}}";
        }
    }
}
