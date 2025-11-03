using Mandatory2DGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class HitX2 : IBoostHit
    {
        public int BoostHit()
        {
            int doubleUp = 2;
            return doubleUp;
        }
    }
}
