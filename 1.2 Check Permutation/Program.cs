using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Check_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplication
            CheckPermutation check = new CheckPermutation();
            string nome = "pedro";
            string name = "deopr";

            Console.WriteLine(check.Permutation(nome, name));
            

            Console.ReadLine();

        }
    }
}
