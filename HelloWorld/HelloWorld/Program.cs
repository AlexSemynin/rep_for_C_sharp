/*начало секции подключаемых пространств имен*/
using System;
/*конец секции подключаемых пространств имен*/

namespace HelloWorld /*объявление нового пространства имен*/
{
    /*
        программа, которая спрашивает у пользователя имя
        и выводит его на консоль
    */

    class Program /*объявление нового класса*/
    {
        // метод Main - стартовая точка приложения
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
