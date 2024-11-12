using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDöngü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 den 10 a kadar olan sayıları ekrana yazdırınız (do while ile)
            //1 den 100 kadar olan sayıların toplamını yazdırınız (do while ile)

            /*int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a<=10);
            Console.ReadLine();*/

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a<=100);

            Console.WriteLine("1 den 100 e kadar olan sayıların TOPLAMI :"+ toplam);

            Console.ReadLine();

        }
    }
}
