using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.Logging;
using Mandatory2DGameFramework.model.Cretures;

namespace Mandatory2DGameFramework.Observer
{
    public class DamageLogging
    {
        private MyLogger _logger;
        public DamageLogging()
        {
            _logger = MyLogger.GetInstance();
        }

        public void LoggingDamage(Creature creature, string message)
        {
            if (creature.HitPoint <= 0)
            {
                _logger.LogCritical(message);
            }
            else if (creature.HitPoint <= 20)
            {
                _logger.LogWarning(message);
            }
            else
            {
                _logger.LogInfo(message);
            }
        }
    }
}
