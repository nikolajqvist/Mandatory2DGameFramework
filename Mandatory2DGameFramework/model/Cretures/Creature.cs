using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.Logging;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public abstract class Creature: WorldObject, IDisposable
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        // Todo consider how many attack / defence weapons are allowed
        public AttackItem? Attack { get; set; }
        public DefenceItem? Defence { get; set; }
        private IBoostRange? _decorator;
        private IReduceHitpoints _reduceHitpoints;
        protected Creature(string name, int hitpoint)
        {
            HitPoint = hitpoint;
        }
        protected Creature(string name, int hitpoint, IBoostRange decorator)
        {
            _decorator = decorator;
            Name = name;
            HitPoint = hitpoint;

            Attack = null;
            Defence = null;
        }
        protected Creature(string name, int hitpoint, IReduceHitpoints reduceHitpoints)
        {
            _reduceHitpoints = reduceHitpoints;
            Name = name;
            HitPoint = hitpoint;

            Attack = null;
            Defence = null;
        }

        protected Creature(string name, int hitpoint, IBoostRange decorator, IReduceHitpoints reduceHitpoints)
        {
            _reduceHitpoints = reduceHitpoints;
            _decorator = decorator;
            Name = name;
            HitPoint = hitpoint;

            Attack = null;
            Defence = null;
        }

        public virtual int Hit()
        {
            if (Attack == null)
            {
                throw new NullReferenceException("Der mangler et svær for at kunne give skade");
            }
            return Attack.Hit;
        }
        public void ReceiveHit(int hit)
        {
            if (Defence != null)
            {
                hit -= Defence.ReduceHitPoint;
                if (hit <= 0)
                {
                    return;
                }
            }
            HitPoint -= hit;
        }
        public virtual void Loot(WorldObject obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException("Der mangler et objekt at loote");
            }
            if (Attack != null & obj is AttackItem attackitem)
            {
                throw new Exception("Har allerde et våben");
            }
            if (Defence != null & obj is DefenceItem defenceitem)
            {
                throw new Exception("Har allerde et skjold");
            }
            if (obj.Lootable)
            {
                if (obj is AttackItem attackItem)
                {
                    Attack = attackItem;
                }
                else if (obj is DefenceItem defenceItem)
                {
                    Defence = defenceItem;
                }
            }
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(HitPoint)}={HitPoint.ToString()}, {nameof(Attack)}={Attack}, {nameof(Defence)}={Defence}}}";
        }

        public void Dispose()
        {
            Attack = null;
            Defence = null;
        }
    }
}
