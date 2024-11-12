using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach döngüsü

            //string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };
            //____________________________________________
            /*for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            */
            //____________________________________________
            /*foreach(string a in isimler)
             {
                 Console.WriteLine(a);
             }
            */
            double toplam = 0;
            double[] ondalikli_sayilar = { 1.2, 1.4, 1.6, 1.8, 2.2 };

            foreach (double A in ondalikli_sayilar)
            {
                toplam += A;
            }
            Console.WriteLine(toplam);

            Console.ReadLine();
          
        }
    }
}
