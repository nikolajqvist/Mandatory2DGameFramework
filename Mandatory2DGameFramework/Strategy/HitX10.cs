using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;

namespace Mandatory2DGameFramework.Decorator
{
    public class HitX10 : IBoostHit
    {
        /// <summary>
        /// Denne metode booster creatures hit
        /// </summary>
        /// <param name="creature">creture to boost</param>
        /// <returns>det boostede hit</returns>
        public int BoostHit(Creature creature)
        {
            return creature.Attack.Hit * 10;
        }
    }
}
