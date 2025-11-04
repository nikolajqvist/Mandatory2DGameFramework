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
        private IDecorateHp _decoratorHp;
        public AbstractHpDecorator(IDecorateHp decoratorHp)
        {
            _decoratorHp = decoratorHp;
        }
        public virtual int DecorateHp() 
        {
            return _decoratorHp.DecorateHp();       
        }
        public virtual IDecorateHp ChangeDecorator(IDecorateHp changeDecorator)
        {
            return changeDecorator;
        }
    }
}
