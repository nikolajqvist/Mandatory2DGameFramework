using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.defence
{
    public class DefenceItem:WorldObject,IReduceHitpoints
    {
        private IReduceHitpoints _reducevenmore;
        public int ReduceHitPoint { get; set; }

        public DefenceItem(string name)
        {
            Name = name;
            ReduceHitPoint = 0;            
        }
        public DefenceItem(string name, IReduceHitpoints reducevenmore)
        {
            Name = name;
            ReduceHitPoint = 0;
            _reducevenmore = reducevenmore;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(ReduceHitPoint)}={ReduceHitPoint.ToString()}}}";
        }

        public void ReduceHitpointsSomeMore(int currentReduction, int toreduceevenmore)
        {
            _reducevenmore.ReduceHitpointsSomeMore(currentReduction, toreduceevenmore);
        }
    }
}
