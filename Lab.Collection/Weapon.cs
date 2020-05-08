using Lab.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Weapon
    {
        
        public string Name;
        public int Damage;
        public int Condition;
        public int Tempo;

        public abstract void Attack();
        public void getStatus()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Damage:" + Damage);
            Console.WriteLine("Condititon:" + Condition + "%");
            Console.WriteLine("Tempo:" + Tempo + "rps");
        }
    }
}