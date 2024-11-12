using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaVeÇıkarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //toplama operatörü: +
            //çıkarma operatörü: -
            int sayi4 = 18;
            int sayi1 = 5;
            int sayi2 = 12;
            int sayi3 = 32;
            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
