using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Đang ăn");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Gâu Gâu");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.ReadLine();
        }
    }
}
