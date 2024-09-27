using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves forward.");
        }

        public void Shoot(IEntity target)
        {
            throw new NotImplementedException();
        }

        public void CastSpell(IEntity target, string spellName)
        {
            Console.WriteLine($"{Name} cast {spellName} on {target.Name}.");
        }
    }
}
