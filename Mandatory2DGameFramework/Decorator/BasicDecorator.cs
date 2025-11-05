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
        private int _hitPoint;
        public BasicDecorator()
        {
            _hitPoint = 0;
        }
        public int DecorateHp(int addsomeHp)
        {
            if(addsomeHp > 5 || addsomeHp < 0)
            {
                throw new ArgumentOutOfRangeException("Skal være mellem 0 og 5");
            }
            return _hitPoint += addsomeHp;
        }
    }
}
