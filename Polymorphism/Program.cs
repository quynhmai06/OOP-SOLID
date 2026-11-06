using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Âm thanh động vật");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Gâu Gâu");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meo Meo");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Speak();
            cat.Speak();
            Console.ReadKey();
        }
    }
}
