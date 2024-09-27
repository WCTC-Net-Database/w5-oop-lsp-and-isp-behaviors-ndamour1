using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _archer;
        private readonly IEntity _mage;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;

        public GameEngine(IEntity character, IEntity archer, IEntity mage, IEntity goblin, IEntity ghost)
        {
            _character = character;
            _archer = archer;
            _mage = mage;
            _goblin = goblin;
            _ghost = ghost;
        }

        public void Run()
        {
            _character.Name = "Blast Hardcheese";
            _archer.Name = "Hawkeye";
            _mage.Name = "Doctor Fate";
            _goblin.Name = "Snorg";
            _ghost.Name = "Z'Skayr";

            _character.Move();
            _character.Attack(_goblin);

            _archer.Move();
            ((Archer)_archer).Shoot(_goblin);

            _mage.Move();
            ((Mage)_mage).CastSpell(_ghost, "Crush");

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_mage);
            ((Ghost) _ghost).Fly();
        }
    }
}
