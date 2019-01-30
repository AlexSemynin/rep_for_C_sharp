using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_0_massParametrovInMethod_keyword_param
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Addition(age, name, 1,2,3);

            //передача массива - как одна переменная
            string[] NameMass = { "в ", "массив ", "мы ", "можем ", "запихнуть ", "Сколько угодно элементов", ", ", "Но передавать в метод будем как один параметр и без ключевого слова" };
            Massiv(NameMass, 10);
            Console.ReadKey();
        }
        static void Addition(int x, string y, params int[] integers)
        {
            int result = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.Write($"Имя: {y}\nВозраст: {x}\n Sum:{result}\n");
        }
        //так же мы можем передать массив в качестве параметров
        static void Massiv(string[] my_mass, int k)
        {
            for(int i = 0; i < my_mass.Length; i++)
            {
                Console.Write(my_mass[i]);
            }
        }
    }
}
