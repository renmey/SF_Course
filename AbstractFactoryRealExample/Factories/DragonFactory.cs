using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample.Factories
{
    internal class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}
