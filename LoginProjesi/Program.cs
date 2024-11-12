using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoginProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı giriş sayfası uygulaması yapacağız
            //kullanıcı adı ve şifresini doğru girerse Tebrikler başarılı bir şekilde giriş yaptınız
            //Yanlış girerse hata verelim ve 3 hak tanıyalım yanlış girdiği sürece döngü dönmeye devam etsin

            int hak = 3;
            while(true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string ka = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz");
                string sifre = Console.ReadLine();

                if ( ka == "OmerAsaf" && sifre == "kerro123")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :)");
                    break;
                }

                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");

                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    
                    if (hak==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur daha giriş yapamazsınız");
                        break;
                    }
                }

            }

            Console.ReadLine();
            

        }
    }
}
