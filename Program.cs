using System;
using ExHeranca.Entities;

namespace ExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1155, "Mis Monteiro", 00.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
