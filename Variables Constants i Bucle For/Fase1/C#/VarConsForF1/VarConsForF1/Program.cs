using System;

namespace VarConsForF1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Carlos";
            string firstSurname = "Garcia";
            string lastSurname = "Gil";

            int birthDay = 22;
            int birthMonth = 10;
            int birthYear = 1973;

            Console.WriteLine($"Name: {firstSurname} {lastSurname}, {name}");
            Console.WriteLine($"Date: {birthDay}/{birthMonth}/{birthYear}");
        }
    }
}
