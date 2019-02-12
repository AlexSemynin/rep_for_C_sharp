using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Events_forMaslyatok_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.Summed += Message; //Закрепляем за событием обработчик
            account.Withdrown += Message;
            account.Put(200);
            account.Withdrow(300);
            Console.ReadKey();
        }
        public static void Message(string mess)
        {
            Console.WriteLine(mess);
        }
        
    }
    
    class Account
    {
        public delegate void MessageHandler(string str);
        public event MessageHandler Summed;
        public event MessageHandler Withdrown;
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public int Sum { get { return _sum; } }
        public void Put(int sum)
        {
            _sum += sum;
            Summed($"Пришло на счет {sum}");
        }
        public void Withdrow(int sum)
        {
            _sum -= sum;
            Withdrown($"Списано {sum}");
        }
    }
}
