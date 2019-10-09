using System;

namespace VarConsForF4
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

            const int leap = 4;

            var myName = $"My name is {name} {firstSurname} {lastSurname}";
            var myBirth = $"I was born {birthDay}/{birthMonth}/{birthYear}";
            var myBirthYear = "";

            if (birthYear % leap == 0)
            {
                myBirthYear = "My year of birth is leap";
            }
            else
            {
                myBirthYear = "My year of birth isn't leap";       
            }
            Console.WriteLine(myName);
            Console.WriteLine(myBirth);
            Console.WriteLine(myBirthYear);
        }
    }
}
