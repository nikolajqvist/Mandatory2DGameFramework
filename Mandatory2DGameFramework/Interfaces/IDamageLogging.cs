using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.model.Cretures;

namespace Mandatory2DGameFramework.Interfaces
{
    public interface IDamageLogging
    {
        public void LoggingDamage(Creature creatrure, string message);
    }
}
