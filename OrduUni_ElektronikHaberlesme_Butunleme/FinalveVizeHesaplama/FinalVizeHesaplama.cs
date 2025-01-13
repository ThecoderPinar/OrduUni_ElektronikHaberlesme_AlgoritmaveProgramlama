using System;

namespace OrduUni_ElektronikHaberlesme_Butunleme.FinalveVizeHesaplama
{
    class FinalVizeHesaplama
    {
        static void Main(string[] args)
        {
            /* 
             * SORU - 2:
             * Final ve Vize Not Hesaplama Programı
             * Kullanıcıdan vize ve final notlarını alarak başarı notunu hesaplayan bir program yazınız.
             * Formül: Başarı Notu = (Vize * 0.4) + (Final * 0.6)
             * 
             * Programı yazarken, sınav sistemi kurallarını dikkate alarak kullanıcıya sınırlandırmalar ekledim.
             * Örneğin, negatif not girilmemesi veya final notunun 50'nin altında olması durumunda açıklayıcı mesajlar ekledim.
             */

            Console.Write("Vize notunu giriniz: ");
            int vize;

            // Geçerli bir vize notu kontrolü
            if (!int.TryParse(Console.ReadLine(), out vize) || vize < 0)
            {
                Console.WriteLine("Geçerli bir vize notu girmelisiniz (0 veya daha büyük bir değer).");
                return;
            }

            Console.Write("Final notunu giriniz: ");
            int final;

            // Geçerli bir final notu kontrolü
            if (!int.TryParse(Console.ReadLine(), out final) || final < 0)
            {
                Console.WriteLine("Geçerli bir final notu girmelisiniz (0 veya daha büyük bir değer).");
                return;
            }

            // Başarı notu hesaplama
            double ort = vize * 0.4 + final * 0.6;

            Console.WriteLine($"\nOrtalamanız: {ort:F2}");

            if (final < 50)
            {
                Console.WriteLine("Final notunuz 50'nin altında olduğu için kaldınız.");
            }
            else if (ort < 50)
            {
                Console.WriteLine("Ortalamanız 50'nin altında olduğu için kaldınız.");
            }
            else
            {
                Console.WriteLine("Tebrikler, geçtiniz!");
            }
        }
    }
}
