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
        private int _hitPoint = 0;
        public BasicDecorator(int hitPoint)
        {
            _hitPoint = hitPoint;
        }
        public int DecorateHp()
        {
            return _hitPoint;
        }
    }
}
