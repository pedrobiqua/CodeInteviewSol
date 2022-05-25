using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Unique
{
    class Program
    {
        /* 
 1.1: Is Unique: Implement an algorithm to determine if a string has all unique characters. 
      What if you cannot use additional data structures ?
        */
        static void Main(string[] args)
        {
            //Aplication
            var unique = new Unique();
            Console.WriteLine(unique.IsUniqueChars("!!"));
            Console.ReadLine();
        }
    }
}
