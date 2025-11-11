using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;
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
        /// <summary>
        /// Denne metode booster creatures hit
        /// </summary>
        /// <param name="creature">Det creature du vil booste</param>
        /// <returns>det boostede hit</returns>
        public int BoostHit(Creature creature)
        {
            return creature.Attack.Hit * 2;
        }
    }
}
