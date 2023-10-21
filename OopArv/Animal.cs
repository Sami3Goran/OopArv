using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
    class Animal
    {
        public string BreedName { get; set; }
        public string HasTail { get; set; }
        public string IsMammal { get; set; }
        public string IsCarnevrious { get; set; }
        public string HuntingStyle { get; set; }

        public Animal(string breedname, string tail, string mammal, string meateater, string huntingstyle)
        {
            BreedName = breedname;
            HasTail = tail;
            IsMammal = mammal;
            IsCarnevrious = meateater;
            HuntingStyle = huntingstyle;
        }

        public virtual void Mating()
        {
            Console.WriteLine("Animal is mating...");
        }

        public virtual void Sleeping() 
        {
            Console.WriteLine("The animal is sleeping...");
        }

        public virtual void Eating()
        {
            Console.WriteLine("The animal is Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }



    }
}
