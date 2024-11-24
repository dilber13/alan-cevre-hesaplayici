using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nALAN ÇEVRE HESAPLAYICI");
            Console.WriteLine("1. Hesaplama yap");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminizi yapın (1/0): ");

            int secim;
            while (!int.TryParse(Console.ReadLine(), out secim) || (secim != 0 && secim != 1))
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 0 veya 1 giriniz.");
                Console.Write("Seçiminizi yapın (1/0): ");
            }

            if (secim == 0)
            {
                Console.WriteLine("Programdan çıkış yapılıyor...");
                break;
            }

            Console.WriteLine("\n1. Alan hesapla");
            Console.WriteLine("2. Çevre hesapla");
            Console.Write("İşlem türünü seçin (1/2): ");

            int islemTuru;
            while (!int.TryParse(Console.ReadLine(), out islemTuru) || (islemTuru != 1 && islemTuru != 2))
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 giriniz.");
                Console.Write("İşlem türünü seçin (1/2): ");
            }

            Console.WriteLine("\n1. Üçgen");
            Console.WriteLine("2. Kare");
            Console.WriteLine("3. Dikdörtgen");
            Console.WriteLine("4. Daire");
            Console.Write("Geometrik şekli seçin (1/2/3/4): ");

            int sekilSecimi;
            while (!int.TryParse(Console.ReadLine(), out sekilSecimi) || (sekilSecimi < 1 || sekilSecimi > 4))
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1, 2, 3 veya 4 giriniz.");
                Console.Write("Geometrik şekli seçin (1/2/3/4): ");
            }

            switch (sekilSecimi)
            {
                case 1: 
                    UcgenIslemleri(islemTuru);
                    break;
                case 2: 
                    KareIslemleri(islemTuru);
                    break;
                case 3: 
                    DikdortgenIslemleri(islemTuru);
                    break;
                case 4: 
                    DaireIslemleri(islemTuru);
                    break;
            }
        }
    }

    static void UcgenIslemleri(int islemTuru)
    {
        Console.WriteLine("\n1. Eşkenar Üçgen");
        Console.WriteLine("2. İkizkenar Üçgen");
        Console.WriteLine("3. Çeşitkenar Üçgen");
        Console.Write("Üçgen tipini seçin (1/2/3): ");

        int ucgenTipi;
        while (!int.TryParse(Console.ReadLine(), out ucgenTipi) || (ucgenTipi < 1 || ucgenTipi > 3))
        {
            Console.WriteLine("Geçersiz seçim! Lütfen 1, 2 veya 3 giriniz.");
            Console.Write("Üçgen tipini seçin (1/2/3): ");
        }

        if (islemTuru == 1)
        {
            if (ucgenTipi == 1)
            {
                Console.Write("Bir kenar uzunluğunu girin: ");
                double kenar = GetDoubleInput();
                double alan = (Math.Sqrt(3) / 4) * Math.Pow(kenar, 2);
                Console.WriteLine($"Eşkenar üçgenin alanı: {alan}");
            }
            else if (ucgenTipi == 2)
            {
                Console.Write("Taban uzunluğunu girin: ");
                double taban = GetDoubleInput();
                Console.Write("Yüksekliği girin: ");
                double yukseklik = GetDoubleInput();
                double alan = (taban * yukseklik) / 2;
                Console.WriteLine($"İkizkenar üçgenin alanı: {alan}");
            }
            else
            {
                Console.Write("Birinci kenar uzunluğunu girin: ");
                double a = GetDoubleInput();
                Console.Write("İkinci kenar uzunluğunu girin: ");
                double b = GetDoubleInput();
                Console.Write("Üçüncü kenar uzunluğunu girin: ");
                double c = GetDoubleInput();
                double s = (a + b + c) / 2;
                double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine($"Çeşitkenar üçgenin alanı: {alan}");
            }
        }
        else
        {
            if (ucgenTipi == 1)
            {
                Console.Write("Bir kenar uzunluğunu girin: ");
                double kenar = GetDoubleInput();
                double cevre = 3 * kenar;
                Console.WriteLine($"Eşkenar üçgenin çevresi: {cevre}");
            }
            else if (ucgenTipi == 2)
            {
                Console.Write("İki eşit kenar uzunluğunu girin: ");
                double kenar = GetDoubleInput();
                Console.Write("Taban uzunluğunu girin: ");
                double taban = GetDoubleInput();
                double cevre = 2 * kenar + taban;
                Console.WriteLine($"İkizkenar üçgenin çevresi: {cevre}");
            }
            else
            {
                Console.Write("Birinci kenar uzunluğunu girin: ");
                double a = GetDoubleInput();
                Console.Write("İkinci kenar uzunluğunu girin: ");
                double b = GetDoubleInput();
                Console.Write("Üçüncü kenar uzunluğunu girin: ");
                double c = GetDoubleInput();
                double cevre = a + b + c;
                Console.WriteLine($"Çeşitkenar üçgenin çevresi: {cevre}");
            }
        }
    }

    static void KareIslemleri(int islemTuru)
    {
        Console.Write("Kenar uzunluğunu girin: ");
        double kenar = GetDoubleInput();

        if (islemTuru == 1)
        {
            double alan = Math.Pow(kenar, 2);
            Console.WriteLine($"Karenin alanı: {alan}");
        }
        else
        {
            double cevre = 4 * kenar;
            Console.WriteLine($"Karenin çevresi: {cevre}");
        }
    }

    static void DikdortgenIslemleri(int islemTuru)
    {
        Console.Write("Kısa kenar uzunluğunu girin: ");
        double kisaKenar = GetDoubleInput();
        Console.Write("Uzun kenar uzunluğunu girin: ");
        double uzunKenar = GetDoubleInput();

        if (islemTuru == 1)
        {
            double alan = kisaKenar * uzunKenar;
            Console.WriteLine($"Dikdörtgenin alanı: {alan}");
        }
        else
        {
            double cevre = 2 * (kisaKenar + uzunKenar);
            Console.WriteLine($"Dikdörtgenin çevresi: {cevre}");
        }
    }

    static void DaireIslemleri(int islemTuru)
    {
        Console.Write("Yarıçapı girin: ");
        double yaricap = GetDoubleInput();

        if (islemTuru == 1)
        {
            double alan = Math.PI * Math.Pow(yaricap, 2);
            Console.WriteLine($"Dairenin alanı: {alan}");
        }
        else
        {
            double cevre = 2 * Math.PI * yaricap;
            Console.WriteLine($"Dairenin çevresi: {cevre}");
        }
    }

    static double GetDoubleInput()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
        }
        return value;
    }
}