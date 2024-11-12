using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shorty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // short degiskeni -32768 ile 32767 arasında deger depolayabilir
            short maxdeger = short.MaxValue;
            short mindeger = short.MinValue;

            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);

            Console.ReadLine();
        }
    }
}
