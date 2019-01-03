using System;

namespace variablesAndBasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Hello, World";
            {
                Console.Write(hello + "\n");
                Console.Write("by, World\n");
            }

            string name = Console.ReadLine();
            int age = 15;
            double weight = 73.5;
              Console.Write($"Имя : {name}\n");
              Console.WriteLine("Возраст: {0}, Вес: {1}", age, weight);
              Console.ReadKey();
        }
    }
}
