using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Observer
{
    public class Unsubscribe
    {
        public void UnsubscripeObserver(NotifyDamage notifyDamage, Creature creature, IDamageLogging loggingdmg)
        {
            if (creature.HitPoint <= 0)
            {
                notifyDamage.RemoveObserver(loggingdmg);
            }
    }
}
