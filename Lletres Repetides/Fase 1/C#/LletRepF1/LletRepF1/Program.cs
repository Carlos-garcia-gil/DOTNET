using System;

namespace LletRepF1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Carlos";
            char[] nameArray = new char[name.Length];
            nameArray = name.ToCharArray();

            foreach (var item in nameArray)
            {
                Console.WriteLine($"Letter: {item}");
            }            
        }
    }
}
