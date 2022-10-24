namespace FinalTaskPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regularAccount = new Account()
            {
                Balance = 900
            };

            regularAccount.CalculateInterest(new RegularAccount());
            Console.WriteLine();

            var salaryAccount = new Account()
            {
                Balance = 1000
            };
            salaryAccount.CalculateInterest(new SalaryAccount());

            

        }
    }
}