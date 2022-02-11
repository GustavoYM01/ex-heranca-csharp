using System;
using heranca_1.Entities;

namespace heranca_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010,
                "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
