using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrduUni_ElektronikHaberlesme_Butunleme.ForDöngüsü
{
    class SayiToplayici
    {
        static void Main(string[] args)
        {
            /* 
 *          SORU - 6:
 *          Alt ve üst sınır arasındaki sayıları toplayan bir program yazınız.
 *          Kullanıcıdan başlangıç ve bitiş değerleri alınarak, bu iki sınır arasındaki tüm tam sayıların toplamını hesaplayın.
 *          Örnek:
 *          Girdi: Başlangıç: 3, Bitiş: 7
 *          Çıktı: 3 ile 7 arasındaki sayıların toplamı: 25
 */

            int baslangic, bitis, toplam = 0; // Toplam değişkeni, sayıların toplamını saklar

            // Kullanıcıdan başlangıç değeri alınıyor
            Console.Write("Başlangıç değeri: ");
            baslangic = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan bitiş değeri alınıyor
            Console.Write("Bitiş değeri: ");
            bitis = Convert.ToInt32(Console.ReadLine());

            // For döngüsüyle başlangıçtan bitişe kadar olan sayılar toplanıyor
            for (int sayi = baslangic; sayi <= bitis; sayi++)
            {
                toplam += sayi; // Her bir sayı, toplam değişkenine ekleniyor
            }

            // Toplam sonucu ekrana yazdırılıyor
            Console.WriteLine($"{baslangic} ile {bitis} arasındaki sayıların toplamı: {toplam}");
            Console.ReadKey(); // Programın kapanmaması için bir tuşa basılması beklenir
        }
    }
}
