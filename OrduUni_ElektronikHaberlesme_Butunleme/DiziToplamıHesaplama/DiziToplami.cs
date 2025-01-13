using System;

namespace OrduUni_ElektronikHaberlesme_Butunleme.DiziToplami
{
    class DiziToplami
    {
        static void Main(string[] args)
        {
            /* 
             * SORU - 4:
             * Dizi Elemanları Toplamı Programı
             * Kullanıcıdan bir dizi boyutu alıp, dizi elemanlarını girdirerek bu elemanların toplamını hesaplayan bir program yazınız.
             * Örnek:
             * Girdi: Dizi Boyutu: 3, Elemanlar: 5, 10, 15
             * Çıktı: Toplam: 30
             * 
             * Bu programı yazarken hata yönetimini dikkate aldım ve kullanıcı dostu bir deneyim sağladım.
             */

            Console.Write("Lütfen dizi boyutunu giriniz: ");
            int boyut;

            // Kullanıcının geçerli bir giriş yapıp yapmadığını kontrol ediyorum
            if (!int.TryParse(Console.ReadLine(), out boyut) || boyut <= 0)
            {
                Console.WriteLine("Geçerli bir pozitif tam sayı giriniz.");
                return;
            }

            // Dizi elemanlarını tanımlama ve toplama
            int[] dizi = new int[boyut];
            int toplam = 0;

            Console.WriteLine("Lütfen dizi elemanlarını giriniz:");
            for (int i = 0; i < boyut; i++)
            {
                Console.Write($"Eleman {i + 1}: ");
                int eleman;

                // Her eleman için geçerli bir giriş kontrolü
                if (!int.TryParse(Console.ReadLine(), out eleman))
                {
                    Console.WriteLine("Geçerli bir tam sayı giriniz.");
                    i--; // Hatalı giriş durumunda aynı eleman için tekrar giriş alınır
                    continue;
                }

                dizi[i] = eleman;
                toplam += eleman; // Elemanı toplama ekleme
            }

            // Toplamı ekrana yazdırma
            Console.WriteLine($"Dizideki elemanların toplamı: {toplam}");
        }
    }
}
