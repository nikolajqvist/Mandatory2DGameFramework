using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class BasicDecorator : IDecorateHp
    {
        public BasicDecorator()
        {
        }
        public int DecorateHp(Creature togiveHp, int addsomeHp)
        {
            return togiveHp.HitPoint += addsomeHp;
        }
    }
}
