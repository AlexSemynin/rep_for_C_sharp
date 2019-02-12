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


            account.Put(200);
            account.Withdrow(300);
            Console.ReadKey();
        }
        public static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
        
    }
    
    class Account
    {

        public delegate void MessageHandler(object sender, AccountEventArgs e);
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
            Summed(this, new AccountEventArgs($"Пришло на счет{sum}", sum));
        }
        public void Withdrow(int sum)
        {
            _sum -= sum;
            Withdrown(this, new AccountEventArgs($"Списано со счета{sum}", sum));
        }
    }
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string mess, int sum)
        {
            Sum = sum;
            Message = mess;
        }
    }
}
