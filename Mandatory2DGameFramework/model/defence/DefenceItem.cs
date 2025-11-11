using Mandatory2DGameFramework.Composite.Interfaces;
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
    public class DefenceItem:WorldObject, IDefenseItem, IDefense
    {
        public int ReduceHitPoint { get; set; }

        public DefenceItem():base("Skjoldpold")
        {
            
        }
        public DefenceItem(string name, int reducehitpoint, bool lootAble, bool removeAble):base(name)
        {
            ReduceHitPoint = reducehitpoint;
            Lootable = lootAble;
            Removeable = removeAble;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(ReduceHitPoint)}={ReduceHitPoint.ToString()}}}";
        }
    }
}
