using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    internal class Monster
    {
        private IWeapon _weapon;
        private IMovement _movement;

        public Monster(IMonsterFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Move()
        {
            _movement.Start();
        }

        public void Hit()
        {
            _weapon.Attack();
        }

    }
}
