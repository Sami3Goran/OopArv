using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopArv
{
    
    class Cat : Animal
    {
        public int CurrentCatLives { get; set; }

        public Cat(string breedname,string tail, string mammal, string meateater, string huntingstyle, int catlives)
            : base(breedname, tail, mammal, meateater,huntingstyle)
        {
            CurrentCatLives = catlives;
        }

        public void Sneaking() 
        {
            Console.WriteLine("Cat is sneaking..");
        }


        public override void Mating()
        {
            Console.WriteLine("The cat is mating...");
        }

        public override void Sleeping()
        {
            Console.WriteLine("Cat is sleeping...");
        }

        public override void Eating()
        {
            Console.WriteLine("Cat is Eating...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mjauuu");
        }

    }
}
