using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class YardCat : IHomeCat

    {
        public string Name { get; set; }

        public void Meow ()
        {
            Console.WriteLine("Myau");

        }

        public void Scratch()
        {
            Console.WriteLine("I scratch but not so strong");
        }
    }
}
