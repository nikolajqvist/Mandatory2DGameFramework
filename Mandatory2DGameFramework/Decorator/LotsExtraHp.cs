using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class LotsExtraHp : AbstractHpDecorator
    {
        public LotsExtraHp(IDecorateHp decorator) : base(decorator)
        {
        }
        public override int DecorateHp()
        {
            int lotsextrahp = 2000;
            int frombase = base.DecorateHp();
            return frombase += lotsextrahp;
        }
    }
}
