using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve operatörü shift+6

            int sayi1 = 5;

            int sayi2 = 5;

            int sayi3 = 10;

            bool kontrol = sayi1 == sayi2 && sayi1 > sayi3;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
