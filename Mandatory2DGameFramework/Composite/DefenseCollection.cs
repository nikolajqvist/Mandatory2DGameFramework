using Mandatory2DGameFramework.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Composite
{
    public class DefenseCollection : IDefense
    {
        private List<IDefense> _defenses;
        public DefenseCollection()
        {
            _defenses = new List<IDefense>();
        }
        public IDefense AddDefense(IDefense adddefense)
        {
            _defenses.Add(adddefense);
            return adddefense;
        }

        public IDefense RemoveDefense(IDefense removedefense)
        {
            _defenses.Remove(removedefense);
            return removedefense;
        }
        public void ShowDefense()
        {
            foreach(IDefense def in _defenses)
            {
                def.ToString();
            }
        }
    }
}
