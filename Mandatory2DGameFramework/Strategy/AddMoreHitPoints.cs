using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Strategy
{
    public class AddMoreHitPoints:IAddHitpoints
    {
        public void MoreHitpoints(Creature creature)
        {
            int addedhp = 50;
            creature.HitPoint += addedhp; 
        }
    }
}
