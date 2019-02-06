using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_1_HacledoBaH
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            Cat cat = new Cat(); cat.Name = "Barsic";
            Dog dog = new Dog(); dog.Name = "Sharic";
            Rat rat = new Rat(); rat.Name = "Businca";

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = rat;

            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("animal " + animals[i].Name + " say:");
                animals[i].GetRRR();
            }
            Console.ReadKey();



            //upcast
            Cat cat1 = new Cat();
            cat1.Name = "Nusha";

            Animal animal1 = cat1;
            cat1.GetRRR();
            Console.ReadKey();

        }
    }
    //Console.WriteLine($"animal {Name} say:\n");
    class Animal
    {
        public string Name { get; set; }
        public virtual void GetRRR()
        {
            Console.WriteLine("RRR");
        }
    }
    class Cat : Animal
    {
        public override void GetRRR()
        {
            Console.WriteLine("Meow");
        }
    }
    class Dog : Animal
    {

    }
    class Rat : Animal
    {

    }
}
