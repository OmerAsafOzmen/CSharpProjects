using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametre alan - Geriye değer döndürmeyen metot yazma

            ToplamaYap(5,7);
            ToplamaYap(6,11);
            CarpConi(3,2,3);
            CarpConi(5,2,3);
            isim("Kerem","Özmen");
            isim("Kadriye","Doğan");

            Console.ReadLine();
        }
        static void ToplamaYap(int sayi1 , int sayi2)
        {
            Console.WriteLine("Gönderilen sayıların toplamı :"+(sayi1+sayi2));
        }
        static void CarpConi(int S1 , int S2 , int S3)
        {
            Console.WriteLine("Gönderilen Sayıların Çarpımı :"+(S1*S2*S3));
        }
        static void isim(string i , string soyi)
        {
            Console.WriteLine("İsim ve Soyisim :"+ i + " "+soyi);
        }
    }
}
