using Lab.Collection;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        [MyAttribute(Name = "Malakhova.A")]
        private static Logger Log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Log.Debug("Debug");
            Log.Error("Error");
               Gun x = new Gun
                {
                    Name = "Walther P38",
                    Damage = 155,
                    Condition = 80,
                    Tempo = 100
                };
                x.getStatus();
                x.Attack();
                Gun x1 = new Gun();
                x1.Attack();
            try
            {
                List<Blade> Knife = new List<Blade>();

                Blade y1 = new Blade() { Name = "НР-40", Damage = 200, Condition = 60, Tempo = 60 };
                Blade y2 = new Blade() { Name = "Nahrkampfmesser", Damage = 210, Condition = 80, Tempo = 50 };
                Blade y3 = new Blade() { Name = "KaBar", Damage = 230, Condition = 100, Tempo = 40 };
                Blade y4 = new Blade() { Name = "Puma", Damage = 190, Condition = 90, Tempo = 65 };
                Blade y5 = new Blade();

                Knife.Add(y1);
                Knife.Add(y2);
                Knife.Add(y3);
                Knife.Add(y4);
                Knife.Add(y5);
                
                foreach (var v in Knife)
                {
                    Console.WriteLine(v.Name + " " + v.Damage + " " + v.Condition);
                }
                List<Blade> SortedList = Knife.OrderBy(b => b.Damage).ToList();
                foreach (var t in SortedList)
                {
                    Console.WriteLine(t.Name + " " + t.Damage);
                }
                Console.WriteLine(Knife.Find(j => j.Name.Contains("3")));                          
            }
            catch (Exception ex)
            {
                Log.Error("Null значение");
                Console.WriteLine(ex.Message); 
             }
            
            Console.ReadKey();
        }
    }
}