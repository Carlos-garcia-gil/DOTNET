using System;

namespace LletRepF1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Carlos";
            var nameArray = new char[name.Length];
            nameArray = name.ToCharArray();

            foreach (var item in nameArray)
            {
                Console.WriteLine($"Letter: {item}");
            }            
        }
    }
}
