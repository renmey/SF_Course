﻿using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample.Factories
{
    internal class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
