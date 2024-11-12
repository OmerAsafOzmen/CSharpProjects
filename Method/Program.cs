using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametresiz - Geriye Değer Döndürmeyen Metot Tanımlama...

            Selamver();
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            AdiniYazdir();

        }
        static void Selamver()
        {
            Console.WriteLine("Selamlar :)");
            
        }
        static void AdiniYazdir()
        {
            Console.WriteLine("Ömer Asaf Özmen");
            Console.ReadLine();
        }

    }
}
