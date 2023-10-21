namespace OopArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Dog1 = new Dog("German Shepard");
            Console.WriteLine($"This dogs breed is {Dog1.BreedName} is he a mammal? :{Dog1.IsMammal}");
            Console.WriteLine($"Does this dog have a tail?: {Dog1.HasTail}, does the dog eat meat?: {Dog1.IsCarnevrious}");
            Console.WriteLine($"what is this dogs way of hunting?: {Dog1.HuntingStyle}, good boy do you wanna play?: {Dog1.LetsPlay}");
            Dog1.Playing();
            Dog1.MakeSound();

            Console.WriteLine("----------------------------------");

            Animal Rabbit = new Animal("Belgian Hare", "Yes", "Yes","No","Does not hunt, loves carrots!");

            Console.WriteLine($"Is the rabbit a meat eater? answer: {Rabbit.IsCarnevrious}");

            Console.WriteLine("----------------------------------");

            Cat cat1 = new Cat("Ragdoll", "yes it has a tail","yes it is a mammal", "yes it eats meat", "sneaking up on pray",9);
            Console.WriteLine($"how many lives does this cat have? {cat1.CurrentCatLives}");
            cat1.Sneaking();
            cat1.MakeSound();

            Console.WriteLine("----------------------------------");

            Bird bird1 = new Bird("Hawk", "yes it has tail", "yes it is a mammal","yes eats meat", "hunts by flying and diving after pray","yes sheds feathers");
            Console.WriteLine($"does the hawk molt? answer:{bird1.Molting}");
            bird1.Eggs();
            bird1.MakeSound();

            Console.WriteLine("----------------------------------");

            Penguin penguin1 = new Penguin(true);
            Console.WriteLine($"Does the penguin swim? answer: {penguin1.Swiming}");
            penguin1.MakeSound();

            Console.WriteLine("----------------------------------");

            Eagle eagle1 = new Eagle(true);
            Console.WriteLine($"Does the eagle fly? Answer: {eagle1.Flying}");
            eagle1.MakeSound();
        }
    }
}