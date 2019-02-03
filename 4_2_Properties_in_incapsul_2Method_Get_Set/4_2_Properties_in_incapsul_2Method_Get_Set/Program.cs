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
            human1.SetAge(10);         //записываем в поле
            int a = human1.GetAge();   //Считывем с поля
            Console.WriteLine(a);
            //для С#-бояр
            Human1 human11 = new Human1();
            human11.Age = 50;          //записываем в поле
            int b = human11.Age;       //Считывем с поля
            Console.Write($"для С#-бояр \n{b}");
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
    //для С#-бояр
    class Human1
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0) { age = value; }
            }
        }
    }
}
