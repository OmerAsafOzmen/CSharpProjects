using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet Tek çift eleman olduğunu 
            // 2- Çift değerlerin toplamı, Tek değerlerin toplamı
            // 3- Son olarak kontrol yapsın, Çift değerlerin toplamı Tek değerlerden büyükse Çift değerlerin toplamı büyüktür yazdırsın. 
            // eğer teklerin toplamı büyükse -> Tek değerlerin toplamı büyüktür yazdırsın...

            int cift = 0;
            int tek = 0;
            int adetc = 0;
            int adett = 0;
            int[] S = new int[10];

            Console.WriteLine("Sizden 10 adet sayı istenmektedir.");

            for (int i = 0; i < S.Length; i++)
            {
                Console.Write((i+1)+". sayıyı giriniz :");
                S[i] = int.Parse(Console.ReadLine()); //Dizimin içini kullanıcıdan aldığım değerlerle doldurdum
                if (S[i]%2==0)
                {
                    cift += S[i];
                    adetc++;
                }
                else
                {
                    tek += S[i];
                    adett++;
                }
            }

            Console.WriteLine("---------------------------------------");

            if (cift>tek)
            {
                Console.WriteLine("Çift değerlerin toplamı büyüktür.");
                Console.WriteLine("Çiftlerin toplamı = "+cift+" Çiftlerin adedi = "+adetc);
                Console.WriteLine("Teklerin toplamı = "+tek+" Teklerin adedi = "+adett);
            }
            else
            {
                Console.WriteLine("Tek değerlerin toplamı büyüktür.");
                Console.WriteLine("Teklerin toplamı = "+tek+" Teklerin adedi = "+adett);
                Console.WriteLine("Çiftlerin toplamı = "+cift+" Çiftlerin adedi = "+adetc);
            }

            Console.ReadLine();

        }
    }
}
