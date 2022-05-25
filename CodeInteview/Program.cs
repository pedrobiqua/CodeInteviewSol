using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInteview
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = { "pedro", "lukas", "Thiago" };
            String[] more = { "avião", "casa", "cachorro" };

            String[] ArrayResizable = Arraylist_ResizableArrays.merge(words, more).ToArray();

            Arraylist_ResizableArrays.print_List(ArrayResizable);

            Dictionary<string, List<string>> foo = new Dictionary<string, List<string>>();
            //Populando
            List<string> map = new List<string>();
            map.Add("Pedro");
            foo.Add("Pedro", map);

            List<string> myService = foo["Pedro"];

            Console.ReadLine();
        }
    }
}
