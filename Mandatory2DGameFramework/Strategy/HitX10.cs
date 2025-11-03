using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Interfaces;

namespace Mandatory2DGameFramework.Decorator
{
    public class HitX10 : IBoostHit
    {
        public int BoostHit()
        {
            int tenIt = 10;
            return tenIt;
        }
    }
}
