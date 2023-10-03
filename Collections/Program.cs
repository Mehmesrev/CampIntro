using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Mehmet", "Semih", "Yusuf", "Atlas"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names.Add("Ensar");
            Console.WriteLine(names[4]);
            
        }
    
    
    }
}