using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
    class Penguin : Bird
    {
        public bool Swiming { get; set; }

        public Penguin(bool swim)
            : base("Penguin", "Yes", "Yes", "Yes, but it eats fish", "Penguins hunt underwater for prey","Yes like many other birds the do molt")
        {
            Swiming = swim;
        }

        public static void UnderWater() 
        {
            Console.WriteLine("The penguin is swimming");
        }

        public override void Eggs()
        {
            Console.WriteLine("The Penguin has layed some eggs!");
        }


        public override void Mating()
        {
            Console.WriteLine("The Bird is mating...");
        }

        public override void Sleeping()
        {
            Console.WriteLine("The Bird is sleeping...");
        }

        public override void Eating()
        {
            Console.WriteLine("The Bird is Eating...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("blub blub");
        }
    }
}
