using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veya operatörü : || altgr+z tuşunun sol tarafındaki büyüktür küçüktür sembolü olan

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrol = sayi1 == sayi2 || sayi1 > sayi3;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
