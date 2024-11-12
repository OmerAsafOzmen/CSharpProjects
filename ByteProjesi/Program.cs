using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 5;

            byte ikinci = 25;

            byte ucuncu = 255;
            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.ReadLine();
        }
    }
}
