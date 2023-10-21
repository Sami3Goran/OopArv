using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
     class Dog : Animal
    {
        public string LetsPlay { get; set; }

        public Dog(string breedname, string WantToPlay = "Yes!!")
         : base(breedname, "Yes", "Yes", "Yes", "Hunts by running after pray")
        {
            LetsPlay = WantToPlay;
        }
                

        public void Playing() 
        {
            Console.WriteLine("The dog wants to play!");
        }


        public override void Mating()
        {
            Console.WriteLine("Dog is mating...");
        }

        public override void Sleeping()
        {
            Console.WriteLine("Dog is sleeping...");
        }

        public override void Eating()
        {
            Console.WriteLine("Dog is Eating...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark bark!");
        }


    }
}
