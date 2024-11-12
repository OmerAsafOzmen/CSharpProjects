using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ÇarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bu projemizde çarpım tablosu yapacağız for döngüsü ile
            /*
            Console.WriteLine("ÇARPIM TABLOSU");
            Console.WriteLine("Birin Katları:");

            for(int a = 1; a<=10; a++)
            {
                Console.WriteLine("bir kere " + a);
                Console.WriteLine(a*1);
            }

            Console.WriteLine("İkinin Katları:");
            for(int b = 1; b<=10; b++)
            {
                Console.WriteLine("iki kere "+ b);
                Console.WriteLine(b*2);
            }

            Console.WriteLine("Üçün Katları:");
            for(int c = 1; c<=10; c++)
            {
                Console.WriteLine("üç kere "+ c);
                Console.WriteLine(c*3);
            }

            Console.WriteLine("Dördün Katları:");
            for(int d = 1; d<=10; d++)
            {
                Console.WriteLine("dört kere "+d);
                Console.WriteLine(d*4);
            }

            Console.WriteLine("Beşin Katları:");
            for(int e = 1; e<=10; e++)
            {
                Console.WriteLine("beş kere " + e);
                Console.WriteLine(e*5);
            }

            Console.WriteLine("Altının Katları:");
            for (int f = 1; f<=10; f++)
            {
                Console.WriteLine("altı kere " + f);
                Console.WriteLine(f*6);
            }

            Console.WriteLine("Yedinin Katları");
            for(int g = 1; g<=10; g++)
            {
                Console.WriteLine("yedi kere "+g);
                Console.WriteLine(g*7);
            }

            Console.WriteLine("Sekizin Katları:");
            for(int h = 1; h<=10; h++)
            {
                Console.WriteLine("sekiz kere "+h);
                Console.WriteLine(h*8);
            }

            Console.WriteLine("Dokuzun Katları:");
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("dokuz kere "+i);
                Console.WriteLine(i*9);
            }

            Console.WriteLine("Onun Katları:");
            for( int j = 1; j<=10; j++)
            {
                Console.WriteLine("on kere "+j);
                Console.WriteLine(j*10);
            }

            Console.ReadLine();
            */

            for(int i=1; i<=10;  i++) //10
            {
                for(int j=1; j<=10; j++) //100
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
            }

            Console.ReadLine();
        }
    }
}
