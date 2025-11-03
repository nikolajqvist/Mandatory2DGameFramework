using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class AbstractHpDecorator : IDecorateHp
    {
        protected readonly IDecorateHp _decorator;
        public AbstractHpDecorator(IDecorateHp decorator)
        {
            _decorator = decorator;
        }
        public virtual int DecorateHp(Creature creature)
        {
            return _decorator.DecorateHp(creature);
        }
    }
}
