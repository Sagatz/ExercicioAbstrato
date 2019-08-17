using System;
using System.Collections.Generic;
using ExercicioAbstract.Entities;


namespace ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxpayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char check = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (check == 'i' || check == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpend = double.Parse(Console.ReadLine());
                    TaxPayer taxpayer = new IndividualTaxPayer(name, anualIncome, healthSpend);

                    taxpayers.Add(taxpayer);
                }
                else if (check == 'c' || check == 'C')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    TaxPayer taxpayer = new CompanyTaxPayer(name, anualIncome, employees);

                    taxpayers.Add(taxpayer);
                }

                Console.WriteLine();
            }

            double total = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in taxpayers)
            {
                Console.WriteLine(tp);
                total += tp.Income();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2"));
        }
    }
}
