using Mandatory2DGameFramework.Composite;
using Mandatory2DGameFramework.Composite.Interfaces;
using Mandatory2DGameFramework.Factory.FactoryInterfaces;
using Mandatory2DGameFramework.Helper;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;

namespace Mandatory2DGameFramework.model.Cretures
{
    /// <summary>
    /// Denne klasses skal arves fra, dette er det creature som du vil oprette i din verden.
    /// </summary>
    public abstract class Creature: WorldObject, IDisposable, ICreature
    {
        public int HitPoint { get; set; }
        public AttackItem? Attack { get; set; }
        public IDefense? Defence { get; set; }
        /// <summary>
        /// Default kontruktør for creature.
        /// </summary>
        protected Creature():base("Troels")
        {
            HitPoint = 120;
            Attack = null;
            Defence = null;
        }
        /// <summary>
        /// Det her sådan et creature bliver født, den skal have et navn og antal hitpoint
        /// </summary>
        /// <param name="name">Navnet på creature.</param>
        /// <param name="hitpoint">Creatures HP.</param>
        protected Creature(string name, int hitpoint):base(name)
        {
            HitPoint = hitpoint;
        }
        public virtual uint Hit()
        {
            if (Attack == null)
            {
                throw new NullReferenceException("Der mangler et sværd for at kunne give skade");
            }
            return Attack.Hit;
        }
        /// <summary>
        /// Denne metode bruges til udregne Hittet fra en anden, men grundet SRP gør den det ikke selv.
        /// </summary>
        /// <param name="hit">Skaden til creature.</param>
        public void ReceiveHit(int hit)
        {
            if(Defence != null)
            CalculateHit.Calculate(Defence, HitPoint, hit);
        }
        /// <summary>
        /// Dette er min loot metode som skal bruge et WorldObject, men det kan kun bruge DefenseItem og AttackItem
        /// </summary>
        /// <param name="obj">Selve objektet du vil loote.</param>
        /// <exception cref="NullReferenceException">Hvis den er null forvejen.</exception>
        /// <exception cref="Exception">Hvis den ikke er null i forvejen.</exception>
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
        /// <summary>
        /// Denne metode smider dit skjold og dit sværd fra dig.
        /// </summary>
        public void Dispose()
        {
            Attack = null;
            Defence = null;
        }
    }
}
