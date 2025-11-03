using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class SomeExtraHp : AbstractHpDecorator
    {
        public SomeExtraHp(IDecorateHp decorator) : base(decorator)
        {
        }
        public override int DecorateHp(Creature creature)
        {
            int someextrahp = 20;
            int frombase = base.DecorateHp(creature);
            return frombase += someextrahp;
        }
    }
}
