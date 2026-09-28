using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Student ID :1690704851
* Name       :Assignment #2
* Section    :129D
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        const string MaterialName = "Iron";
        const double SmeltRate = 0.2500;
        const double SalvageRate = 0.3000;
        const double MaxBatch = 500;

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--       Welcome to the Forge     --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();

            if (double.TryParse(amountInput, out double amount)
                && amount > 0
                && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double ingot = amount * SmeltRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double ore = amount / SalvageRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("=> Error: Invalid menu.");
                }
            }
            else
            {
                Console.WriteLine("=> Error: Invalid amount.");
            }
        }
    }
}

