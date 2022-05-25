using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInteview
{
    public class Arraylist_ResizableArrays
    {
        public static List<String> merge(String[] words, String[] more)
        {
            List<String> sentence = new List<String>();
            foreach (var w in words)
            {
                sentence.Add(w);
            }

            foreach (var m in more)
            {
                sentence.Add(m);
            }

            return sentence;
        }

        public static void print_List<T>( T[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("value:=" + item);
            }
        }
    }
}
