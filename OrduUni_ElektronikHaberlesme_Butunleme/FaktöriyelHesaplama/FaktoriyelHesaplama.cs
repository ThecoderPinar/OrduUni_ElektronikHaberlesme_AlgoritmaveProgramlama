using System;

namespace OrduUni_ElektronikHaberlesme_Butunleme.FaktöriyelHesaplama
{
    class FaktöriyelHesaplama
    {
        static void Main(string[] args)
        {
            /* 
             * SORU - 1:
             * Faktöriyel Hesaplama Programı
             * Kullanıcıdan bir tam sayı alarak bu sayının faktöriyelini hesaplayan bir program yazınız.
             * Örnek: 
             * Girdi: 5
             * Çıktı: 5! = 120
             * 
             * Bu kodu yazarken kullanıcı dostu bir yapı hedefledim. Negatif sayılar için faktöriyel tanımlı olmadığından,
             * bunu kullanıcıya güzel bir mesajla açıklıyorum. Ayrıca, programı modüler ve temiz bir şekilde yazmaya çalıştım.
             */

            Console.Write("Lütfen bir tam sayı giriniz: ");
            int sayi;

            // Kullanıcının geçerli bir giriş yapıp yapmadığını kontrol ediyorum.
            if (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.WriteLine("Geçerli bir tam sayı girmelisiniz.");
                return;
            }

            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
            }
            else
            {
                long faktoriyel = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i; // Burada döngüyle faktöriyel hesaplıyorum.
                }
                Console.WriteLine($"{sayi}! = {faktoriyel}");
            }
        }
    }
}
