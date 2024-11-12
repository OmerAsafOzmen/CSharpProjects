using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi -9.223.372.036.854.775.808 to 9.223.372.036.854.775.807 arasında deger depolayabilmektedir
            //8 byte yer kaplar ram bellekte

            long birinci = 575000;

            long ikinci = -100000000;

            long maxdeger = long.MaxValue;

            long mindeger = long.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);

            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);

            Console.ReadLine();
        }
    }
}
