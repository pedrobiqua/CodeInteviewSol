using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Is Unique: Implement an algorithm to determine if a string has all unique
            //characters. What if you cannot use additional data structures ?

            //Aplication
            var unique = new Unique();
            Console.WriteLine(unique.IsUniqueChars("!!"));
            Console.ReadLine();
        }
    }
}
