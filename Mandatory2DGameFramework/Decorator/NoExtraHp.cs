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

        public override int DecorateHp(int addsomeHp)
        {
            if(addsomeHp != 0)
            {
                throw new ArgumentOutOfRangeException("Skal være 0, buhuu!");
            }
            return base.DecorateHp(addsomeHp);
        }
    }
}
