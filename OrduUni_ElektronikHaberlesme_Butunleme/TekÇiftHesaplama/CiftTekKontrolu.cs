using System;

namespace OrduUni_ElektronikHaberlesme_Butunleme.CiftTekKontrolu
{
    class CiftTekKontrolu
    {
        static void Main(string[] args)
        {
            /* 
             * SORU - 3:
             * Sayı Çift mi Tek mi Kontrol Programı
             * Kullanıcıdan bir tam sayı alarak bu sayının çift mi yoksa tek mi olduğunu bulan bir program yazınız.
             * Örnek:
             * Girdi: 7
             * Çıktı: Tek Sayı
             * 
             * Bu programı yazarken, kullanıcı deneyimini artırmak için açıklayıcı mesajlar ekledim.
             * Ayrıca, hatalı girişlere karşı koruma ekledim.
             */

            Console.Write("Lütfen bir tam sayı giriniz: ");
            int sayi;

            // Kullanıcının geçerli bir tam sayı girip girmediğini kontrol ediyorum
            if (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.WriteLine("Geçerli bir tam sayı girmelisiniz.");
                return;
            }

            // Sayının çift mi yoksa tek mi olduğunu kontrol ediyorum
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} bir Çift Sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} bir Tek Sayıdır.");
            }
        }
    }
}
