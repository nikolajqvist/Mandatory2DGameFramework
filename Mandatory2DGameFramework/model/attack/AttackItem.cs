using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class AttackItem : WorldObject, IBoostRange
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }
        private IBoostRange _decorator;
        public AttackItem(string name, int hit, int range)
        {
            Name = name;
            Hit = hit;
            Range = range;
        }
        public AttackItem(string name, int hit, int range, IBoostRange decorator)
        {
            Name = name;
            Hit = hit;
            Range = range;
            _decorator = decorator;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit.ToString()}, {nameof(Range)}={Range.ToString()}}}";
        }

        public void BoostedRange(int currentrange, int addRange)
        {
            _decorator.BoostedRange(currentrange, addRange);
        }
    }
}
