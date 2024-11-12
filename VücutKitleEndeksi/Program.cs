using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VücutKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beden kitle Indeksi = kilo / boy*boy
            //beden kitle Indeksi 18 'e eşit veya düşükse ZAYIF
            //18 ile 25 arasındaysa NORMAL
            //25 'ten büyükse OBEZ yazdıran program parçasını kodlayınız

            Console.WriteLine("Kilonuzu giriniz:");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double indeks = kilo / (boy * boy);

            if (indeks <= 18)
            {
                Console.WriteLine("Vücut kitle endeksi ZAYIF.");
                Console.WriteLine("Endeks değeri "+indeks);
                Console.ReadLine();
            }
            else if (indeks >18 && indeks <=25)
            {
                Console.WriteLine("Vücut kitle endeksi NORMAL.");
                Console.WriteLine("Endeks değeri "+indeks);
                Console.ReadLine();
            }
            else if(indeks >25)
            {
                Console.WriteLine("Vücut kitle endeksi OBEZ.");
                Console.WriteLine("Endeks değeri "+indeks);
                Console.ReadLine();
            }
            //BOY VİRGÜLLE GİRİLİR: (Örneğin;1,83)
        }
    }
}
