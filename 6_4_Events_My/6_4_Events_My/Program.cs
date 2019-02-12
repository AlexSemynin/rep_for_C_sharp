using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_Events_My
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.Widthdrown += Display;
            account.AddedSum += Display;
            account.Put(200);
            account.Withdrow(200);
            Console.ReadKey();
        }
        static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Cумма транзакции {e.Sum}");
            Console.WriteLine(e.Messege);
            Console.WriteLine($"Остаток{e.Ost}");
        }
    }
    class Account
    {
        public delegate void MessegeHandler(object sender, AccountEventArgs e);
        public event MessegeHandler AddedSum;
        public event MessegeHandler Widthdrown;
        int _sum;
        public int Sum { get { return _sum; } }
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            _sum += sum;
            AddedSum(this, new AccountEventArgs("Добавлено на счет", sum, _sum));
        }
        public void Withdrow(int sum)
        {
            _sum -= sum;
            Widthdrown(this, new AccountEventArgs("Снято со счета", sum, _sum));
        }
    }
    class AccountEventArgs
    {
        public int Sum { get; }
        public string Messege { get; }
        public int Ost { get; }
        public AccountEventArgs(string mess, int sum, int ost)
        {
            Sum = sum;
            Messege = mess;
            Ost = ost;
        }
    }
}
