﻿using System;

namespace NomsCiutatsF2
{
    class Program
    {
        static void Main(string[] args)
        {
            var city1 = "";
            var city2 = "";
            var city3 = "";
            var city4 = "";
            var city5 = "";
            var city6 = "";
            const int numCities = 6;

            for (var i = 0; i < numCities; i++)
            {
                Console.Write($"Name city num.{i + 1}: ");
                var stringInput = Console.ReadLine();
                Console.WriteLine();
                switch (i)
                {
                    case 0:
                        city1 = stringInput;
                        break;
                    case 1:
                        city2 = stringInput;
                        break;
                    case 2:
                        city3 = stringInput;
                        break;
                    case 3:
                        city4 = stringInput;
                        break;
                    case 4:
                        city5 = stringInput;
                        break;
                    case 5:
                        city6 = stringInput;
                        break;
                }
            }

            var arrayCities = new string[] { city1, city2, city3, city4, city5, city6 };
            Array.Sort(arrayCities);

            Console.WriteLine();
            Console.WriteLine("The cities sorted are the next: ");
            foreach (var item in arrayCities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
