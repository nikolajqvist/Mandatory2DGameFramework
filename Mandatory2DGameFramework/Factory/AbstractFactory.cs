using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IAttackItem CreateAttackItem();
        public abstract IDefenseItem CreateDefenseItem();
        public abstract ICreature CreateCreature();
    }
}
