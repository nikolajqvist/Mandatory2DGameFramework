using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class AttackItem : WorldObject, IAttackItem
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }
        public AttackItem(string name, int hit, int range)
        {
            Name = name;
            Hit = hit;
            Range = range;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit.ToString()}, {nameof(Range)}={Range.ToString()}}}";
        }
    }
}
