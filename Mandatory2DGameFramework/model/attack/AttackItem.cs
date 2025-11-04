using Mandatory2DGameFramework.Decorator;
using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    /// <summary>
    /// Dette er attackitem klassen
    /// </summary>
    public class AttackItem : WorldObject, IAttackItem
    {
        private IBoostHit? _boostHit;
        public IBoostHit? BoostHit { get { return _boostHit; } set { _boostHit = value; } }
        /// <summary>
        /// Dette er AttackItems "styrke".
        /// </summary>
        public uint Hit
        {
            get { return this.Hit; }
            set { if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hit kan ikke være under 0");
                }
                this.Hit = value;
            }
        }
        /// <summary>
        /// Dette er AttackItems længde på våbenet.
        /// </summary>
        public uint Range 
        { 
            get { return this.Range; } 
            set { if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Range kan ikke være under 0");
                }
                this.Range = value;
            } 
        }
        public AttackItem():base("Sværd")
        {
            Hit = 120;
            Range = 5;
        }
        /// <summary>
        /// Det her er sådan et attackitem bliver født, den skal have name, hit og range, boostHit er nullable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hit"></param>
        /// <param name="range"></param>
        /// <param name="boostHit"></param>
        public AttackItem(string name, uint hit, uint range, IBoostHit? boostHit = null) : base(name)
        {
            Hit = hit;
            Range = range;
            _boostHit = (boostHit == null)? new HitNormal() : boostHit;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit.ToString()}, {nameof(Range)}={Range.ToString()}}}";
        }
    }
}
