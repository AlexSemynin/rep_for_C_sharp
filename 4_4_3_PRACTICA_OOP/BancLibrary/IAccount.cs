using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancLibrary
{
    interface IAccount
    {
        void Put(decimal sum);         //положить деньги на счет
        void GetMoney(decimal sum);    //взять
    }
}
