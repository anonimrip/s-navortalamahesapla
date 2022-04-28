using System;

namespace nothesaplama
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] yazili_notlari = new int[3];
            int topla = 0;
            for (int i = 0; i < yazili_notlari.Length; i++)
            {
                Console.WriteLine("Sınav Notunuzu Giriniz: ");
                yazili_notlari[i] = Convert.ToInt32(Console.ReadLine());
                topla = topla + yazili_notlari[i];

            }
            Console.WriteLine("Toplamları: " + topla);
            int hesapla = (yazili_notlari[0] + yazili_notlari[1] + yazili_notlari[2]) / 3;
            Console.Write("Ortalamaları: ");
            Console.Write(hesapla);
        }
    }
}