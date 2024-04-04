using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct
{
    internal  abstract class Animal
    {
        public abstract void Eat();
        
    }
    abstract class Bird: Animal
    {
        public abstract  void Fly();
        
    }
    class Parrot: Bird
    {
        public override  void Eat()
        {
            Console.WriteLine("Eat as Parrot");
        }
    }
    public override void Fly()
    {
        Console.WriteLine("Flay as Parrot");
    }
    public void Talk()
    {
        Console.WriteLine("Cici kush");
    }
    class Eagle: Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }
        public override void Fly()
        {
            Console.WriteLine("Fly ad Eagle");
        }
    abstract class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
    class Shark :Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Sharks");
        }
    }
}
