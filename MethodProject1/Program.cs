using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan aldığımız sayının karesini alalım eğer karesi 25'ten büyükse;
            //karesi 25'ten büyüktür
            //değilse 25'ten küçüktür yazdırsın.

            Console.Write("Karesini almak istediğiniz sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int A = Kare(sayi);

            if(A>25)
            {
                Console.WriteLine("Karesi 25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten küçüktür.");
            }
            Console.WriteLine("Değeri "+A);

            Console.ReadLine();
        }
        static int Kare(int S1)
        {
            return S1 * S1;
        }
    }
}
