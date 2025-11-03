using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class NoExtraHp : AbstractHpDecorator
    {
        public NoExtraHp(IDecorateHp decorator) : base(decorator)
        {
        }

        public override int DecorateHp(Creature creature)
        {
            int decoHp = 0;
            int frombase = base.DecorateHp(creature);
            return frombase += decoHp;
        }
    }
}
