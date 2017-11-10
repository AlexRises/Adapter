using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class CatInfoPrinter
    {
        public static void PrintCatInfo (IHomeCat cat)
        {
            Console.WriteLine("Cat info:");
            Console.WriteLine(string.Format("Cat Name: {0}", cat.Name));
            Console.WriteLine("Type of myuay");
            cat.Meow();
            Console.WriteLine("Typr of Scratching");
            cat.Scratch();

            Console.WriteLine();
        }
    }
}
