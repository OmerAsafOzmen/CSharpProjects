using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDöndürenMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametre alan - geriye değer döndüren metot tanımlama.
            //Return anahtar kelimesi
            //Metot sonu.

            Console.Write("Bir sayı giriniz: ");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı daha giriniz: ");
            int S2 = Convert.ToInt32(Console.ReadLine());

            int DonenDeger = toplamayap(S1,S2);

            if(DonenDeger > 10)
            {
                Console.WriteLine("Değer 10'dan büyüktür");
            }
            else
            {
                Console.WriteLine("Değer 10'dan küçüktür");
            }


            string GelenİSoyi = isimSoyisim("Ömer","Asaf");

            Console.WriteLine(GelenİSoyi);



            Console.ReadLine();
        }
        static int toplamayap(int sayi1 , int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;
        }        

        static string isimSoyisim(string i,string soyi)
        {
            return i+" "+soyi;

            //Return Değerleri Döndürür
            //Metodu bitiren anahtar kelimedir.
        }
    }
}
