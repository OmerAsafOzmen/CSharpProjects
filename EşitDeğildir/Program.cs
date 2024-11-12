using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EşitDeğildir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eşit değildir operatörü: !=

            int sayi1 = 4;
            int sayi2 = 4;

            bool kontrol = sayi1 != sayi2;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
