using System;

namespace BasitATM
{
    class ATMSimulasyonu
    {
        static void Main(string[] args)
        {
            /*
             * SORU - 7:
             * Basit ATM Simülasyonu
             * 
             * Bu programda bir ATM'yi simüle etmeyi hedefledim. Kullanıcı, başlangıçta bir hesap bakiyesi ile başlar ve şu işlemleri yapabilir:
             * 1. Para Yatırma
             * 2. Para Çekme
             * 3. Bakiye Sorgulama
             * 4. Çıkış Yapma
             * 
             * Bu uygulama benim için, kullanıcı dostu bir deneyim sunmayı ve temel programlama mantığını ortaya koymayı amaçladığım bir projedir.
             * Kullanıcının hatalı girişlerini kontrol altına aldım ve net mesajlarla işlem sonuçlarını iletmeye özen gösterdim.
             */

            decimal bakiye = 1000.0m; // Başlangıç bakiyesi, program için başlangıç noktası
            int secim;

            Console.WriteLine("=== Basit ATM Sistemine Hoş Geldiniz ===");

            do
            {
                // Kullanıcıya menü seçeneklerini sunuyorum
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1. Para Yatırma");
                Console.WriteLine("2. Para Çekme");
                Console.WriteLine("3. Bakiye Sorgulama");
                Console.WriteLine("4. Çıkış Yap");

                // Kullanıcının seçimini alıyorum
                Console.Write("Seçiminiz: ");
                if (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        // Para yatırma işlemi
                        Console.Write("Yatırmak istediğiniz miktarı giriniz: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal yatirilanMiktar) && yatirilanMiktar > 0)
                        {
                            bakiye += yatirilanMiktar;
                            Console.WriteLine($"Başarıyla {yatirilanMiktar:C} yatırdınız. Güncel bakiyeniz: {bakiye:C}");
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir miktar giriniz.");
                        }
                        break;

                    case 2:
                        // Para çekme işlemi
                        Console.Write("Çekmek istediğiniz miktarı giriniz: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal cekilenMiktar) && cekilenMiktar > 0)
                        {
                            if (cekilenMiktar <= bakiye)
                            {
                                bakiye -= cekilenMiktar;
                                Console.WriteLine($"Başarıyla {cekilenMiktar:C} çektiniz. Güncel bakiyeniz: {bakiye:C}");
                            }
                            else
                            {
                                Console.WriteLine("Hata: Yetersiz bakiye.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir miktar giriniz.");
                        }
                        break;

                    case 3:
                        // Bakiye sorgulama işlemi
                        Console.WriteLine($"Güncel bakiyeniz: {bakiye:C}");
                        break;

                    case 4:
                        // Çıkış işlemi
                        Console.WriteLine("Çıkış yapılıyor. İyi günler dilerim! :)");
                        break;

                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen 1-4 arasında bir değer giriniz.");
                        break;
                }

            } while (secim != 4); // Kullanıcı çıkış seçeneğini seçene kadar döngü devam eder
        }
    }
}
