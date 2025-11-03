using Mandatory2DGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class HitNormal : IBoostHit
    {
        public int BoostHit()
        {
            return 0;
        }
    }
}
