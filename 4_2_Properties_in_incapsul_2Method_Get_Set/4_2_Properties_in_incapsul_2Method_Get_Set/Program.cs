using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_Properties_in_incapsul_2Method_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.SetAge(10);
            int a = human1.GetAge();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
    class Human
    {
        private int age;
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int value)
        {
            if (value > 0)
            {
                age = value;
            }
            else { Console.WriteLine("Введите Ваш истинный возраст"); }
        }
    }
}
