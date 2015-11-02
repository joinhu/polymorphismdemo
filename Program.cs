using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("The animal ate!");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog ate!");
        }
    }

    class Bird : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The bird ate!");
        }
    }

    class Fish : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The fish ate!");
        }
    }

    class Program
    {
        public static void Main()
        {
            Dog myDog = new Dog();
            Bird myBird = new Bird();
            Fish myFish = new Fish();
            Animal myAnimal = new Animal();

            myAnimal.Eat();

            myAnimal = myDog;
            myAnimal.Eat();
            myAnimal = myBird;
            myAnimal.Eat();
            myAnimal = myFish;
            myAnimal.Eat();
        }
    }
}
