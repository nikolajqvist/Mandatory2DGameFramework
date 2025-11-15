using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.worlds
{
    public abstract class WorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }
        public Position Position { get; set; }
        public WorldObject(string name, Position position)
        {
            Position = position;
            Name = name;
            Lootable = false;
            Removeable = false;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Lootable)}={Lootable.ToString()}, {nameof(Removeable)}={Removeable.ToString()}}}";
        }
    }
}
