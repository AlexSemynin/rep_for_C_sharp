using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Delegate_Practica
{
    class Account
    {
        //pole
        private int _sum;
        //Construct
        public Account(int sum)
        {
            _sum = sum;
        }
        //Acsessor
        public int CurrentSum { get { return _sum; } }
        //Method
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if(_del != null) { _del($"Сумма{sum} снята со счета"); }
            }
            else { if (_del != null) { _del("Недостаточно средств"); } }
        }


        //Объявление делегата 
        public delegate void AccountStateHandler(string messege);
        //Создание переменной делегата
        private AccountStateHandler _del;
        //Регистрация длегата
        public void RegisterHAndler(AccountStateHandler del) //вызываемы метод, где в качестве параметра передаётся делегат 
        {
            _del = del;
        }
    }
}
