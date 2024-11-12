using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string
            //double
            //char

            //string[] isimler = { "Enes", "Yasin", "Mehmet", "Ercan", "Kasım" };

            //double[] ondalikli_sayilar = { 1.44, 7.66, 8.34, 10.5 };

            char[] karakter = { 'E', 'N', 'E', 'S' };

            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }

            Console.ReadLine();
        }
    }
}
