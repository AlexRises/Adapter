using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Vaska";
            CatInfoPrinter.PrintCatInfo(vaska);

            IHomeCat petka = new PedigreeCat();
            petka.Name = "Petka";
            CatInfoPrinter.PrintCatInfo(petka);

            Console.ReadLine();
        }
    }
}
