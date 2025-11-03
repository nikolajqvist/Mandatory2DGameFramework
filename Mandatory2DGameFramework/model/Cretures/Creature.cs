using Mandatory2DGameFramework.Composite;
using Mandatory2DGameFramework.Composite.Interfaces;
using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;

namespace Mandatory2DGameFramework.model.Cretures
{
    public abstract class Creature: WorldObject, IDisposable, ICreature
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public AttackItem? Attack { get; set; }
        public IDefense? Defence { get; set; }
        private IDecorateHp? _decorateHp;
        private IBoostHit? _boostHit;
        protected Creature(string name, int hitpoint, 
            IDecorateHp? decorateHp, IBoostHit? boostHit)
        {
            Name = name;
            HitPoint = hitpoint;
            _decorateHp = decorateHp;
            _boostHit = boostHit;
        }
        public int Hit()
        {
            if (Attack == null)
            {
                throw new NullReferenceException("Der mangler et sværd for at kunne give skade");
            }
            if (_boostHit != null)
            {
                Attack.Hit *= _boostHit.BoostHit();
            }
            return Attack.Hit;
        }
        public void ReceiveHit(int hit)
        {
            if (Defence != null)
            {
                if(Defence is DefenceItem defense)
                {
                    hit -= defense.ReduceHitPoint;
                }
                if (hit <= 0)
                {
                    return;
                }
            }
            HitPoint -= hit;
        }
        public void Loot(WorldObject obj)
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
        public void ChangeStrategy(IBoostHit changedBoostHitStrategy)
        {
            _boostHit = changedBoostHitStrategy;
        }
    }
}
