using Lab.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Gun : Weapon
    {
        [MyAttribute(Name = "Malakhova.A")]
        public int Magazine;

        public override void Attack()
        {
            Console.WriteLine("DPS:" + ((Damage - (Damage - Damage * Condition / 100)) * Tempo));
        }
    }
}