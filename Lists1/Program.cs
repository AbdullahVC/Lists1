using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> ziyaretciIsimleri = new List<string>();
        string cevap;

        Console.WriteLine("Hoş geldiniz! Gala gecesi için davetli listemizi hazırlıyoruz.");
        Console.WriteLine("Lütfen davet etmek istediğiniz kişilerin isimlerini girin.");

        do
        {
            Console.Write("\nBir isim yazın: ");
            string isim = Console.ReadLine();
            ziyaretciIsimleri.Add(isim);

            Console.WriteLine($"{isim} listemize eklendi! Başka birini daha eklemek ister misiniz?");
            Console.Write("(evet veya hayır): ");
            cevap = Console.ReadLine().ToLower();

            if (cevap == "hayır")
            {
                Console.WriteLine("\nTamam! Listeyi tamamladık.");
            }
            else if (cevap == "evet")
            {
                Console.WriteLine("Harika! O zaman bir isim daha alalım.");
            }
            else
            {
                Console.WriteLine("Anlayamadım, lütfen 'evet' veya 'hayır' yazar mısınız?");
            }

        } while (cevap != "hayır");

        Console.WriteLine("\nDavetli listemiz şu şekilde:");

        // Listeyi numaralandırarak yazdırıyoruz
        for (int i = 0; i < ziyaretciIsimleri.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ziyaretciIsimleri[i]}");
        }

        Console.WriteLine("\nGala gecemize katıldığınız için teşekkürler!");
    }
}
