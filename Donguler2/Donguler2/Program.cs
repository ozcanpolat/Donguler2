using System;

namespace Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sınırsız sayıda ürün ismini bir dizi içinde saklayın.
            // Ürün adetini kullanıcı belirlesin.
            // Eklenen ürünler listelensin.

            Console.Write("Ürün adetini girin :");
            int adet = int.Parse(Console.ReadLine());

            string[] urunler = new string[adet];

            int i = 0;

            do
            {
                Console.Write($"{i + 1}. Ürün Adı :");
                urunler[i]=Console.ReadLine();
                i++;

            } while (adet != i);

            Console.WriteLine("ürünler listeniyor...");

            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine($"{a + 1}.ürün adı: {urunler[a]}");
            }
        }
    }
}
