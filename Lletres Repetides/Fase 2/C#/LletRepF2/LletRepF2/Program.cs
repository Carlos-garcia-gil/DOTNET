using System;
using System.Collections.Generic;

namespace LletRepF2
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Carlos";
            var nameList = new List<char>();

            for (int i = 0; i < name.Length; i++)
            {
                nameList.Add(Convert.ToChar(name.Substring(i,1)));
            }

            foreach (var item in nameList)
            {
                Console.Write($"Letter: {item} ");
                switch (char.ToLower(item))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("is VOCAL");
                        break;
                    default:
                        if (int.TryParse(item.ToString(), out int num)) 
                        {
                            Console.WriteLine("People names don't contain numbers!");
                        }
                        else
                        {
                            Console.WriteLine("is CONSONANT");
                        }
                        break;
                }
            }
        }
    }
}
