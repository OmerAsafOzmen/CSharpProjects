using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doğum tarihi girilen kişinin yaşını hesaplayan programın kodunu yazınız.

            int tarih = 2024;

            Console.Write("Doğum tarihinizi giriniz: ");
            int dogum = Convert.ToInt32(Console.ReadLine());
            int yas = tarih - dogum;

            Console.WriteLine("Yaşınız "+yas);

            Console.ReadLine();
        }
    }
}
