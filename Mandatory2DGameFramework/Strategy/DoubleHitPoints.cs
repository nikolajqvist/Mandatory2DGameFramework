using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Strategy
{
    public class DoubleHitPoints : IAddHitpoints
    {
        public void MoreHitpoints(Creature creature)
        {
            int doubleHitpoints = 2;

            creature.HitPoint *= doubleHitpoints;
        }
    }
}
