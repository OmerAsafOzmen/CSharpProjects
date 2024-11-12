using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İnt veri tipi -2.147.483.647 ile 2.147.483.647 arasında deger depolayabilir
            //4 byte yer kaplar ram bellekte

            //8 bit = 1 byte
            //1024 byte = 1 kilobyte
            //1024 kilobyte = 1 megabyte
            //1024 megabyte = 1 gigabyte
            //1024 gigabyte = 1 terabyte
            //1024 terabyte = 1 petabyte

            int birincidegisken = 150000;

            int ikincidegisken = -500000;

            int maxdeger = int.MaxValue;

            int mindeger = int.MinValue;

            //Console.WriteLine(birincidegisken);

            //Console.WriteLine(ikincidegisken);

            Console.WriteLine(maxdeger);

            Console.WriteLine(mindeger);
            
            Console.ReadLine();
            
        }
    }
}
