using System;

namespace OrduUni_ElektronikHaberlesme_Butunleme.HesapMakinesi
{
    class App
    {
        static void Main(string[] args)
        {
            /* 
             * SORU - 5:
             * Basit Hesap Makinesi Programı
             * Kullanıcıdan iki sayı ve bir işlem türü (+, -, *, /) alarak sonucu hesaplayan bir program yazınız.
             * Örnek:
             * Girdi: Sayı 1: 20, Sayı 2: 5, İşlem: /
             * Çıktı: Sonuç: 4
             * 
             * Kullanıcı dostu ve hatalara karşı dayanıklı bir yapı hedeflenmiştir.
             */

            Console.Write("Lütfen birinci sayıyı giriniz: ");
            double sayi1;

            // Geçerli bir sayı kontrolü
            if (!double.TryParse(Console.ReadLine(), out sayi1))
            {
                Console.WriteLine("Geçerli bir sayı girmelisiniz.");
                return;
            }

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            double sayi2;

            // Geçerli bir sayı kontrolü
            if (!double.TryParse(Console.ReadLine(), out sayi2))
            {
                Console.WriteLine("Geçerli bir sayı girmelisiniz.");
                return;
            }

            Console.Write("Lütfen bir işlem türü giriniz (+, -, *, /): ");
            string islem = Console.ReadLine();

            // İşlemin yapılması
            double sonuc;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
                    break;

                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
                    break;

                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
                    break;

                case "/":
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Hata: Bir sayıyı 0'a bölemezsiniz.");
                    }
                    else
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz bir işlem türü girdiniz. Lütfen +, -, * veya / giriniz.");
                    break;
            }
        }
    }
}
