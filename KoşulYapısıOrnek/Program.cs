using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulYapısıOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            //eğer 80-100 arasındaysa A+ yazdıran
            //60-80 arasındaysa A yazdıran
            //40-60 arasındaysa B+ yazdıran
            //40dan küçükse F yazdıran örneğin kod parçalarını yazınız.

            Console.WriteLine("Birinci sınav notunu giriniz:");
            string sayi1 = Console.ReadLine();
            int sayint1= Convert.ToInt32(sayi1);

            Console.WriteLine("İkinci sınav notunu giriniz:");
            string sayi2 = Console.ReadLine();
            int sayint2 = Convert.ToInt32(sayi2);

            Console.WriteLine("Üçüncü sınav notunu giriniz:");
            string sayi3 = Console.ReadLine();
            int sayint3 = Convert.ToInt32(sayi3);

            int ortalama = (sayint1 + sayint2 + sayint3) / 3;

            if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("Tebrikler! A+ aldınız");
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("Böyle devam et A aldınız");
            }
            else if (ortalama >= 40 && ortalama < 60)
            {
                Console.WriteLine("Daha iyisi olabilir.. B aldınız");
            }
            else
            {
                Console.WriteLine("Üzgünüm F aldınız");
            }
            Console.ReadLine();








        }
    }
}
