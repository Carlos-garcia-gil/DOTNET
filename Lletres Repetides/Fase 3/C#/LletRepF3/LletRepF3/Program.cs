using System;
using System.Collections.Generic;

namespace LletRepF3
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "carlos";
            var nameList = new List<char>();
            var nameDictionary = new Dictionary<char, int>(); 

            for (int i = 0; i < name.Length; i++)
            {
                nameList.Add(char.ToLower(Convert.ToChar(name.Substring(i, 1))));
            }

            foreach (var item in nameList)
            {
                if (nameDictionary.ContainsKey(item))
                {
                    nameDictionary[item] += 1;
                }
                else 
                {
                    nameDictionary.Add(item, 1);
                }
            }

            foreach (var item in nameDictionary)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
        }
    }
}
