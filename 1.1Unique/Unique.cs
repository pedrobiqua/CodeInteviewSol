using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Unique
{
    public class Unique
    {
        /// <summary>
        /// Verifica se o texto apresenta caracteres unicos ou não.
        /// </summary>
        /// <param name="str">Texto a ser analisado</param>
        public bool IsUniqueChars(string str)
        {
            if (str.Length > 256) return false;
            bool[] char_set = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {//Already found this char in string 
                    return false;
                }
                char_set[val] = true;
            }
            
            return true;
        }
    }
}
