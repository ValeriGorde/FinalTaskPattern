using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskPattern
{
    public class RegularAccount : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;

            Console.WriteLine("Процентная ставка обычного аккаунта: " + account.Interest);

        }
    }

    public class SalaryAccount : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставка зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;

            Console.WriteLine("Процентная ставка зарплатного аккаунта: " + account.Interest);
        }
    }

}
