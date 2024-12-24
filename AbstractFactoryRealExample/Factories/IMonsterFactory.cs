using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

namespace AbstractFactoryRealExample
{
    internal interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();

    }
}
