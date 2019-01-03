/*начало секции подключаемых пространств имен*/
using System;
/*конец секции подключаемых пространств имен*/

namespace HelloWorld /*объявление нового пространства имен*/
{
    class Program /*объявление нового класса*/
    {
        static void Main(string[] args) /*объявление нового метода*/
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine(); /*Считываем с консоли строку*/
            Console.WriteLine($"Привет, {name}");
            Console.WriteLine("this is your first programs on C#, and tribute to God Programming");
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
