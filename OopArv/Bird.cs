using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
     class Bird : Animal
     {
        public string Molting { get; set; }

        public Bird(string breedname, string tail, string mammal, string meateater, string huntingstyle, string ShedingFeathers)
            : base(breedname, tail, mammal, meateater, "Uses beaks, claws for hunting.")
        {
            Molting = ShedingFeathers;
        }


        public virtual void Eggs()
        {
            Console.WriteLine("The Bird has layed some eggs!");
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
            Console.WriteLine("Tweet tweet");
        }


    }
}
