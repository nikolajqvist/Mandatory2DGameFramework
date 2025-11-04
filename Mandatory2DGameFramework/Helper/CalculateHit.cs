using Mandatory2DGameFramework.Composite.Interfaces;
using Mandatory2DGameFramework.model.defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Helper
{
    public static class CalculateHit
    {
        public static void Calculate(IDefense def, int hit, int hp)
        {
            if (def != null)
            {
                if (def is DefenceItem defence)
                {
                    hit -= defence.ReduceHitPoint;
                }
                if (hit <= 0)
                {
                    return;
                }
                hp -= hit;
            }
        }
    }
}
