using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class PedigreeCat : IHomeCat
    {
        public void Meow()
        {
            Console.WriteLine("Уррр");
        }

        public void Scratch()
        {
            Console.WriteLine("I don't scratch");
        }

        public string Name { get; set; }
    }
}
