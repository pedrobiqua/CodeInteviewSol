using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Check_Permutation
{
    class CheckPermutation
    {
        public string Sort(string str)
        {
            char[] content = str.ToArray();
            Array.Sort(content);
            string returno = new string(content);

            return returno;
        }

        public bool Permutation(string s, string t)
        {
            if (s.Length != t.Length) return false;
            return Sort(s).Equals(t);
        }

    }
}
