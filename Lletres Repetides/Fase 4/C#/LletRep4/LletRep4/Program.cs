using System;
using System.Collections.Generic;

namespace LletRep4
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "carlos";
            var surname = "garcia";
            var nameList = new List<char>();
            var surnameList = new List<char>();
            var fullNameList = new List<char>();

            for (var i = 0; i < name.Length; i++)
            {
                nameList.Add(Convert.ToChar(name.Substring(i, 1)));
            }

            for (int i = 0; i < surname.Length; i++)
            {
                surnameList.Add(Convert.ToChar(surname.Substring(i, 1)));
            }

            fullNameList.AddRange(nameList);
            fullNameList.Add(' ');
            fullNameList.AddRange(surname);

            foreach (var item in fullNameList)
            {
                Console.Write(item);
            }
        }
    }
}
