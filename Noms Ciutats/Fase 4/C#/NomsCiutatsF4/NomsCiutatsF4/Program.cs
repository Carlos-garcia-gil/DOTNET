using System;

namespace NomsCiutatsF4
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

            var arrayCity1 = CreateArrayChar(city1);
            var arrayCity2 = CreateArrayChar(city2);
            var arrayCity3 = CreateArrayChar(city3);
            var arrayCity4 = CreateArrayChar(city4);
            var arrayCity5 = CreateArrayChar(city5);
            var arrayCity6 = CreateArrayChar(city6);

            Console.WriteLine();
            Console.WriteLine("The cities are the next: ");

            Array.Reverse(arrayCity1);
            Console.WriteLine(arrayCity1);

            Array.Reverse(arrayCity2);
            Console.WriteLine(arrayCity2);

            Array.Reverse(arrayCity3);
            Console.WriteLine(arrayCity3);

            Array.Reverse(arrayCity4);
            Console.WriteLine(arrayCity4);

            Array.Reverse(arrayCity5);
            Console.WriteLine(arrayCity5);

            Array.Reverse(arrayCity6);
            Console.WriteLine(arrayCity6);
        }
        static char[] CreateArrayChar(string city) 
        {
            var arrayChar = new char[city.Length];

            // En lugar del for podiamos haber utilizado el ToCharArray, pero he utilizado el for
            // porque el enunciado indicaba que rellenaramos el array letra por letra.
            //arrayChar = city.ToCharArray();

            for (var i = 0; i < city.Length; i++)
            {
                arrayChar[i] = char.Parse(city.Substring(i, 1));     
            }
            return arrayChar;
        }
    }
}
