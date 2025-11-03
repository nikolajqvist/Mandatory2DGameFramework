using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Interfaces;

namespace Mandatory2DGameFramework.Decorator
{
    public class HitX5 : IBoostHit
    {
        public int BoostHit()
        {
            int fiveIt = 5;
            return fiveIt;
        }
    }
}
