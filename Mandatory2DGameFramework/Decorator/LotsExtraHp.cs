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
        public override int DecorateHp(int addLotsOfHp)
        {
            if(addLotsOfHp > 2000 || addLotsOfHp < 500)
            {
                throw new ArgumentOutOfRangeException("Skal være mellem 500 og 2000");
            }
            return base.DecorateHp(addLotsOfHp);
        }
    }
}
