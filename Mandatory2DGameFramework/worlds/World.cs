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
        private readonly XmlClass? _xml;
        // Todo: Parameter sørge for at det giver det samme og ikke den ene skal være tal og den anden string fx. MaXX, MaXY.
        /// <summary>
        /// Denne konstruktør lader dig undgå Xml og selv skrive tallene på din verden og sværhedsgraden.
        /// </summary>
        /// <param name="difficulty">Sværhedsgrad.</param>
        /// <param name="maxx">Max x værdi.</param>
        /// <param name="maxY">Max y værdi.</param>
        public World(string difficulty, int maxx, int maxY)
        {
            Difficulty = difficulty;
            MaxX = maxx;
            MaxY = maxY;
            _creatures = new List<Creature>();
            _worldObjects = new List<WorldObject>();
        }
        /// <summary>
        /// Denne konstruktør bruger Xml fil og henter værdien i filen.
        /// </summary>
        /// <param name="difficulty">Skriv Easy, Normal eller Svær</param>
        /// <param name="MaXX">Skriv MaxX</param>
        /// <param name="MaXY">Skriv MaxY</param>
        /// <param name="xml">Xml filen du henter parametre fra.</param>
        public World(string difficulty, string MaXX, string MaXY, XmlClass? xml = null)
        {
            _xml = xml;
            MaxX = _xml.GetXmlInt(MaXX);
            MaxY = _xml.GetXmlInt(MaXY);
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
