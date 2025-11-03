using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.defence
{
    public class DefenceItem:WorldObject, IDefenseItem
    {
        public int ReduceHitPoint { get; set; }

        public DefenceItem(string name)
        {
            Name = name;
            ReduceHitPoint = 0;            
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(ReduceHitPoint)}={ReduceHitPoint.ToString()}}}";
        }
    }
}
