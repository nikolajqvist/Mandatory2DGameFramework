using Mandatory2DGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Decorator
{
    public class BoostRange : IBoostRange
    {
        public void BoostedRange(int currentrange, int addRange)
        {
            currentrange += addRange;
        }
    }
}
