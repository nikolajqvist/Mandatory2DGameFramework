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
    public abstract class Creature
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }

        // Todo consider how many attack / defence weapons are allowed
        public AttackItem? Attack { get; set; }
        public DefenceItem? Defence { get; set; }
        protected Creature()
        {
            Name = string.Empty;
            HitPoint = 100;

            Attack = null;
            Defence = null;
        }
        public virtual int Hit()
        {
            if(Attack == null)
            {
                throw new NullReferenceException("Der mangler et svær for at kunne give skade");
            }
            return Attack.Hit;
        }
        public void ReceiveHit(int hit)
        {
            HitPoint -= hit;
        }
        public virtual void Loot(WorldObject obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException("Der mangler et objekt at loote");
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

    }
}
