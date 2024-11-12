using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürDönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İNT VERİ TİPİNDEN  BYTE VERİ TİPİNE DÖNÜŞTÜRME
            //int a = 500;
            //byte b = (byte)a;

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b);
            //Console.ReadLine();
            //STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME
            //string sayi1 = "1";
            //string sayi2 = "2";

            //int a = int.Parse(sayi1); 
            //int b = int.Parse(sayi2); 


            //Console.WriteLine(a+b);

            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);

            //İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜRME

            /*int sayi = 5;
            int sayi2 = 10;

            string a = sayi.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(b+a);
            Console.ReadLine();*/

            //DOUBLE VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME

            //double sayi = 5.22; //double dan int e çevirirken sayının ondalık kısmı yuvarlanır.

            //int a = Convert.ToInt32(sayi);

            //int b = int.Parse(sayi);

            //Console.WriteLine(a);
            //Console.WriteLine(sayi.GetType());
            //Console.ReadLine();

            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR ...
            /*Console.WriteLine("Lütfen yaşınızı giriniz:");
            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            Console.ReadLine();*/


            //kullanıcıdan iki tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yazınız
            Console.WriteLine("birinci sayıyı giriniz:");
            string sayi1 = Console.ReadLine();

            Console.WriteLine("ikinci sayıyı giriniz:");
            string sayi2 = Console.ReadLine();

            int sayi1int = Convert.ToInt32(sayi1);
            int sayi2int = Convert.ToInt32(sayi2);
            Console.WriteLine("Sonuç:");
            Console.WriteLine(sayi1int+sayi2int);

            Console.ReadLine();

            //ToString();
            //Convert.ToInt();
            //int.parse();
            //double.parse();
            //(int)

        }
    }
}
