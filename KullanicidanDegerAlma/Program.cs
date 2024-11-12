using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //readline 

            Console.WriteLine("Lütfen adınızı giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz lütfen");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi:" + isim);
            Console.WriteLine("Kullanıcının Soyadı:" + soyisim);
            Console.ReadLine();
        }
    }
}
