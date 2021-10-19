using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaha;
            double vyska;
            double vypocet;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("vypocet BMI");
                Console.WriteLine("-----------------");

                Console.Write("zadej vahu:");
                double.TryParse(Console.ReadLine(), out vaha);

                if (vaha <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("jenom cisla nad 30 plati");
                }
                else
                {
                    Console.Write("zadej vysku (cm): ");
                    double.TryParse(Console.ReadLine(), out vyska);
                    if (vyska <= 100)
                    {
                        Console.WriteLine();
                        Console.WriteLine("jenom cisla nad 100 plati");
                    }
                    else
                    {
                        vypocet = Math.Pow(vyska / 100, 2);
                        vypocet = vaha / (vypocet);
                        Console.WriteLine();
                        Console.Write($"Tvoje BMI je {vypocet}.");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
