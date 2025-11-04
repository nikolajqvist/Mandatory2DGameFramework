using Mandatory2DGameFramework.Composite.Interfaces;
using Mandatory2DGameFramework.model.defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Composite
{
    /// <summary>
    /// Denne klasse er en composite som har en liste af IDefense som klassen her også implemnter. 
    /// </summary>
    public class DefenseCollection : IDefense
    {
        private List<IDefense> _defenses;
        /// <summary>
        /// Denne property udregner summen af alle DefenseItems i listen.
        /// </summary>
        public int ReduceHitPoint { get { return _defenses.Sum(d => d.ReduceHitPoint); } }
        public DefenseCollection()
        {
            _defenses = new List<IDefense>();
        }

        /// <summary>
        /// Denne metode tilføjer en type af IDefense til listen.
        /// </summary>
        /// <param name="adddefense">er en IDefense (DefenseItem eller DefenseCollection)</param>
        /// <exception cref="ArgumentNullException">Exception.</exception>
        public void AddDefense(IDefense adddefense)
        {
            if (adddefense != null)
            {
                _defenses.Add(adddefense);
            }
            else
            {
                throw new ArgumentNullException("Kunne ikke tilføje denne IDefense.");
            }
        }
        /// <summary>
        /// DEnne metoder fjerner en type af IDefense til listen.
        /// </summary>
        /// <param name="removedefense">er en IDefense (DefenseItem eller DefenseCollection)</param>
        /// <exception cref="ArgumentNullException">Exception.</exception>
        public void RemoveDefense(IDefense removedefense)
        {
            if (removedefense != null)
            {
                _defenses.Remove(removedefense);
            }
            else
            {
                throw new ArgumentNullException("Kunne ikke fjerne denne IDefense");
            }
        }
        }
    }
}
