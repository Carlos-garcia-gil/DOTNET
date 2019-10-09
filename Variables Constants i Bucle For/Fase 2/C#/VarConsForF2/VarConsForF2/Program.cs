using System;

namespace VarConsForF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 1973;

            const int year = 1948;
            const int leap = 4;

            var leapYear = (birthYear - year) / leap + 1;
            Console.WriteLine($"Between the year {year} and {birthYear} there are {leapYear} leap years");
        }
    }
}
