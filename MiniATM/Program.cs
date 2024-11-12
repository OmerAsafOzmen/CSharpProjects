using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            //Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            //1-bakiye görüntüleme
            //2-para çekme
            //3-para yatırma
            //q ya basarsa çıkış yaptıracağız

            Console.WriteLine("ATM ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1- Bakiye Görüntüleme 2-Para Çekme 3-Para Yatırma q-Çıkış yap");

            string secim = Console.ReadLine();

            if (secim =="1")
            {
                Console.WriteLine("Şuan ki bakiyeniz: "+bakiye);
                Console.ReadLine();
            }

            else if (secim=="2")
            {
                Console.WriteLine("Lütfen çekmek istediğiniz para miktarını yazınız:");
                string cekim = Console.ReadLine();
                int cekimint = Convert.ToInt32(cekim);
                if (cekimint <= bakiye)
                {
                    int kalan = bakiye - cekimint;
                    Console.WriteLine("Kalan bakiyeniz: " + kalan);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                    Console.ReadLine();
                }
            }

            else if (secim=="3")
            {
                Console.WriteLine("Lütfen yatırmak istediğiniz para miktarını yazınız:");
                string yatirim = Console.ReadLine();
                int yatirimint = Convert.ToInt32(yatirim);
                int sonuc = bakiye + yatirimint;
                Console.WriteLine("Sonuç bakiyeniz: "+sonuc);
                Console.ReadLine();
            }

            else if(secim=="q")
            {
                Console.WriteLine("ATM ' den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı iyi günler ...");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.WriteLine("1, 2, 3, q gibi");
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }   

    }
}
