using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilarİfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrencinin notu 50 den büyükse başarılı, değilse başarısız yazdıran program çıktısını kodlayınız.

            int not = 55;

            if (not > 50) //true, false
            {
                Console.WriteLine("Öğrenci bu dersten başarılı bir şekilde geçmiştir.");

            }

            else
            {
                Console.WriteLine("Dersten başarısız oldunuz");
            }

            Console.ReadLine();
        }
    }
}
