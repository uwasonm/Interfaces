namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // an interface declares what a class should have
            // an inheriting class defines how it should do it

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();
            Hawk hawk = new Hawk();
            hawk.Hunt();
            Bird bird = new Bird();
            bird.Flee();
            bird.Hunt();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }
        class Rabbit: IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The Rabbit runs away");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine(" The hawk is searching for food");
            }
        }

        class Bird : IPredator,IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The bird runs away");
            }
            public void Hunt()
            {
                Console.WriteLine("The bird is searching for food");
            }
        }

    }
}
