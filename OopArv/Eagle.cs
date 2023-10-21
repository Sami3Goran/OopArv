using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
    class Eagle : Bird
    {
        public bool Flying { get; set; }

        public Eagle(bool fly)
            : base("Eagle", "Ýes", "Yes", "Yes", "The eagle hunts by soaring and diving","The eagle does shed feathers")
        {
            Flying = fly;
        }

        public static void Inthesky() 
        {
            Console.WriteLine("The eagle is flying High!");
        }

        public override void Eggs()
        {
            Console.WriteLine("The Eagle has layed some eggs!");
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
            Console.WriteLine("AAUUUGGHHH");
        }
    }
}
