using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Archer : IEntity, IShootable
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
            Console.WriteLine($"{Name} shot {target.Name} with an arrow.");
        }

        public void Cast(IEntity target, string spellName)
        {
            throw new NotImplementedException();
        }
    }
}
