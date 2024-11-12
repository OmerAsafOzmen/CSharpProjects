using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziProje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayı dizinin içinde varmı ? kontrol eden varsa kaç tane olduğunu söyleyen 
            //yoksa da yoktur diye uyaran programı kodlayınız.

            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            int adet = 0;
            bas:
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
           
            for(int i = 0;i<sayilar.Length;i++)
            {
                if(sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if(adet == 0)
            {
                Console.WriteLine("Girdiğiniz değer dizide bulunamadı...");
                goto bas;
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulundu...");
                Console.WriteLine("Adet : "+ adet);
            }
            Console.ReadLine();

        }
    }
}
