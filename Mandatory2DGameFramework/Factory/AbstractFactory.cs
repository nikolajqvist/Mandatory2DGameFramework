using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Factory
{
    /// <summary>
    /// Denne klasse laver en creature, men den skal arves fra.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IAttackItem CreateAttackItem(IAttackItem itemToCreate);
        public abstract IDefenseItem CreateDefenseItem(IDefenseItem itemToCreate);
        public abstract ICreature CreateCreature(ICreature creatureToCreate);
    }
}
