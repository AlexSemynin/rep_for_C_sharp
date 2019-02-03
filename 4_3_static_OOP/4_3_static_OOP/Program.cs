using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_static_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            user1.DisplayCountUser();
            Console.WriteLine(User.countUser); //можно обратиться не через экземпляр класса, а через Имя класса, если поле открытое, как тут))
            Console.ReadKey();
        }
    }
    class User
    {
        //Статические поля применяются для хранения счетчиков
        public static int countUser = 0;                                //Тут
        //Конструктор по созданию пользователей
        public User()
        {
            countUser += 1;
        }
        //Статические методы могут общаться только со статическими членами класса
        public void DisplayCountUser()
        {
            Console.WriteLine($"Количество пользователей{countUser}");
        }
    }
}
