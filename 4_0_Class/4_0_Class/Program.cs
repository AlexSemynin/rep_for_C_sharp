using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_0_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            findNumb NameClass; //Создали пустую переменную, в которой может храниться экземпляр нашего класса
            findNumb NameClass2 = new findNumb(); //после выполнения оператора new в прееменной FirstClass2 хранится экземпляр класса
            int res = NameClass2.MaxNumb(10, 20);
            Console.WriteLine(res);
            Console.ReadKey();

            Person noname = new Person();
            noname.age = 23;
            noname.GetInfo();

            Person bob = new Person("Жора", 21);
            bob.GetInfo();
            Console.ReadKey();
        }
    }
    class Person
    {
        public string name;
        public int age;
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
        }
        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }
        public Person()
        {
            name = "Неизвестно";
            age = 0;
        }
    }
}
