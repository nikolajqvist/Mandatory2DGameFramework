using Mandatory2DGameFramework.model.Cretures;
using Mandatory2DGameFramework.Xml;
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
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public string Difficulty { get; set; }
        // world objects
        private List<WorldObject> _worldObjects;
        // world creatures
        private List<Creature> _creatures;
        private readonly XmlClass _xml;

        public World(XmlClass xml, string difficulty)
        {
            _xml = xml;
            MaxX = _xml.GetXmlInt("MaxX");
            MaxY = _xml.GetXmlInt("MaxY");
            Difficulty = _xml.GetXmlString(difficulty);
            _worldObjects = new List<WorldObject>();
            _creatures = new List<Creature>();            
        }
        public override string ToString()
        {
            return $"{{{nameof(MaxX)}={MaxX.ToString()}, {nameof(MaxY)}={MaxY.ToString()}}}";
        }
    }
}
