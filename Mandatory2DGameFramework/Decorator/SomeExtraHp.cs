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
        public override int DecorateHp(int addSomeHp)
        {
            if (addSomeHp > 30 || addSomeHp < 10)
            {
                throw new ArgumentOutOfRangeException("Skal være mellem 10 og 30");
            }
            return base.DecorateHp(addSomeHp);
        }
    }
}
