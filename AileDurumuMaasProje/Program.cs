using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileDurumuMaasProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fabrikada çalışan bir işçinin çocuk sayısı ve ürettiği parça sayısına göre toplam maaşını hesaplayan programın kodu
            //1 çocuk:%5 prim , 2 çocuk:%10 prim , 3 çocuk:%15 prim
            //50 ile 100 arasında parça sayısı:%10 prim , 100 ile 150 arası parça sayısı:%15 prim , 150 ve üstü parça sayısı:%20 prim

            double toplam = 0;
            double csp = 0;
            double psp = 0;

            Console.WriteLine("Maaşınızı giriniz");
            int maas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çocuk sayısını giriniz");
            int cs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parça sayısını giriniz");
            int ps = Convert.ToInt32(Console.ReadLine());

            if (cs == 1)
            {
                csp = maas * 0.05;
            }
            else if (cs == 2)
            {
                csp = maas * 0.1;
            }
            else if(cs >= 3)
            {
                csp = maas * 0.15;
            }

            if (ps >= 50 && ps < 100)
            {
                psp = maas * 0.1;
            }
            else if(ps >= 100 && ps <150)
            {
                psp = maas * 0.15;
            }
            else if(ps >=150)
            {
                psp = maas * 0.2;
            }

            toplam = maas + csp + psp;

            Console.WriteLine("Toplam maaşınız :"+toplam);
            Console.ReadLine();
        }
    }
}
