using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktöriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            basadon:

            Console.WriteLine("Faktöryel hesaplamak için");
            Console.Write("Bir sayı giriniz: ");

            pozitif:

            int faktor = Convert.ToInt32(Console.ReadLine());
            long hesap = 1;

            if (faktor<0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                goto pozitif;
            }
            else if(faktor==0)
            {
                Console.WriteLine("Sonuç = 0");
            }
            else
            {
                for(int i = 1;i<=faktor;i++)
                {
                    hesap *= i;
                }
                string hesap2 = Convert.ToString(hesap);
                Console.WriteLine(hesap2);
            }
            goto basadon;

        }
    }
}
