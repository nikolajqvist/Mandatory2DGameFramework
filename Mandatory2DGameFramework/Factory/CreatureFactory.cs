using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.Cretures;
using Mandatory2DGameFramework.model.defence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Factory
{
    /// <summary>
    /// Denne klasse er en factory du kan bruge istedet for at lave din egen.
    /// </summary>
    public class CreatureFactory : AbstractFactory
    {
        public override IAttackItem CreateAttackItem(IAttackItem itemToCreate)
        {
            return itemToCreate;
        }
        public override ICreature CreateCreature(ICreature creatureToCreate)
        {
            return creatureToCreate;
        }

        public override IDefenseItem CreateDefenseItem(IDefenseItem itemToCreate)
        {
            return itemToCreate;
        }
    }
}
