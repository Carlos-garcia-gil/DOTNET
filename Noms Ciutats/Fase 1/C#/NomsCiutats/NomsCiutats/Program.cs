using System;

namespace NomsCiutats
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
                Console.Write($"Name city num.{i+1}: ");
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
            
            Console.WriteLine();
            Console.WriteLine("The cities are the next: ");
            for (var i = 0; i < numCities; i++)
            {
                var stringOutput = "";
                switch (i)
                {
                    case 0:
                        stringOutput = city1;
                        break;
                    case 1:
                        stringOutput = city2;
                        break;
                    case 2:
                        stringOutput = city3;
                        break;
                    case 3:
                        stringOutput = city4;
                        break;
                    case 4:
                        stringOutput = city5;
                        break;
                    case 5:
                        stringOutput = city6;
                        break;
                }
                Console.WriteLine(stringOutput);
            }
        }
    }
}
