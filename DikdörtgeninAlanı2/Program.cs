using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdörtgeninAlanı2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dikdörtgen alan hesaplama.

            Console.WriteLine("Uzun kenarı giriniz:");
            string UK = Console.ReadLine();

            Console.WriteLine("Kısa kenarı giriniz:");
            string KK = Console.ReadLine();

            int UKint = Convert.ToInt32(UK);
            int KKint = Convert.ToInt32(KK);

            Console.WriteLine("Sonuç");
            Console.WriteLine(UKint*KKint);
            Console.ReadLine();

        }
    }
}
