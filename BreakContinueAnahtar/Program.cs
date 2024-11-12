using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinueAnahtar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break anhtar kelimesi 
            //continue anahtar kelimesi

            for(int a =1; a<=10; a++)
            {
                if (a==7)
                {
                    continue;
                }
                Console.WriteLine("a nın değeri : "+a);
            }
            Console.ReadLine();

            //break döngüyü parçalar
            //continue döngüde bir bölümü atlar

        }
    }
}
