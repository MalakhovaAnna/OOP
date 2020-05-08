using Lab.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Blade : Weapon
    {
        [MyAttribute(Name = "Malakhova.A")]
        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
