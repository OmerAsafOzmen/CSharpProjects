using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mini ATM Uygulaması yapalım kulanıcıdan bir deger alalım aldığmız degere göre işlemler yapalım(switch - case) kullanıcaz.
            //1- bakiye görüntüleme
            //2- para çek
            //3- para yatır
            //4- çıkış yap
            //1-2-3-4 dışında bir değer girilmiş ise hata versin.

            int bakiye = 700;

            Console.WriteLine("ATM ye hoşgeldiniz");

            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1- Bakiye görüntüleme");
            Console.WriteLine("2- Para çekme");
            Console.WriteLine("3- Para yatırma");
            Console.WriteLine("4- çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :"+bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekim = Convert.ToInt32(Console.ReadLine());
                    if (cekim > bakiye)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiye "+(bakiye-cekim));
                    }
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirim = Convert.ToInt32(Console.ReadLine());
                    int sonuc = bakiye + yatirim;
                    Console.WriteLine("Sonuç bakiyeniz "+sonuc);
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan Çıkış yapılıyor lütfen bekleyin...");
                    Console.WriteLine("Çıkış başarıyla yapıldı iyi günler.");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
