using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.Cretures;

namespace Mandatory2DGameFramework.Observer
{
    public class NotifyDamage
    {
        private readonly List<IDamageLogging> _observers = new List<IDamageLogging>();

        public void AddObserver(IDamageLogging observer) 
        {
            _observers.Add(observer); 
        }
        public void RemoveObserver(IDamageLogging observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Creature creature, string message)
        {
            foreach (DamageLogging observer in _observers)
            {
                observer.LoggingDamage(creature, message);
            }
        }
    }
}
