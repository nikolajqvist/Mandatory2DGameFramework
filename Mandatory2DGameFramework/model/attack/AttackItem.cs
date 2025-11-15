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
        private int _hit;
        private int _range;
        public IBoostHit? BoostHit { get { return _boostHit; } set { _boostHit = value; } }
        /// <summary>
        /// Dette er AttackItems "styrke".
        /// </summary>
        public int Hit
        {
            get { return _hit; }
            set { if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hit kan ikke være under 0");
                }
                _hit = value;
            }
        }
        /// <summary>
        /// Dette er AttackItems længde på våbenet.
        /// </summary>
        public int Range 
        { 
            get { return _range; } 
            set { if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Range kan ikke være under 0");
                }
                _range = value;
            } 
        }
        public AttackItem():base("Sværd", new Position(0, 0))
        {
            Hit = 2;
            Range = 1;
        }
        /// <summary>
        /// Det her er sådan et attackitem bliver født, den skal have name, hit og range, boostHit er nullable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hit"></param>
        /// <param name="range"></param>
        /// <param name="lootAble"></param>
        /// <param name="removeAble"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="boostHit"></param>
        public AttackItem(string name, int hit, int range, bool lootAble, bool removeAble, int placementX, int placementY, Position position, IBoostHit? boostHit = null) : base(name, position)
        {
            Hit = hit;
            Range = range;
            Lootable = lootAble;
            Removeable = removeAble;
            _boostHit = (boostHit == null) ? new HitNormal() : boostHit;
        }
        public void ChangeStrategy(IBoostHit newstrategy)
        {
            _boostHit = newstrategy;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit.ToString()}, {nameof(Range)}={Range.ToString()}}}";
        }
    }
}
