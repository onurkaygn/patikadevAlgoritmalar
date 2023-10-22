using System;

namespace patikaAlgoritmalar
{
    class Program
    {
        static void Main(string[] args) {
            //Tüm örnekler özellikle hazır fonksiyonlar kullanmadan çözüldü.
            Ornek1();
            Ornek2();
            Ornek3();
            Ornek4();         
        }
        static void Ornek1()
        {
            Console.WriteLine("1. UYGULAMA BAŞLANGICI.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pozitif bir sayı giriniz...");
            int number10 = Convert.ToInt32(Console.ReadLine());

            if (number10 == 0 || number10 < 0)
            {
                Console.WriteLine("0 veya negatif sayılar kabul edilmemektedir.");
            }
            else
            {
                for (int i = 1; i < number10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        static void Ornek2()
        {
            Console.WriteLine("2. UYGULAMA BAŞLANGICI.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("İki adet pozitif sayı giriniz...");
            int number20 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. pozitif sayıyı giriniz...");
            int number21 = Convert.ToInt32(Console.ReadLine());
            int[] array20 = new int[number20];
            int countOfArray20 = array20.Count();
            if (number20 == 0 || number21 == 0 || number20 < 0 || number21 < 0)
            {
                Console.WriteLine("Sadece pozitif sayı giriniz.");
            }
            else
            {
                Console.WriteLine(number20 + " adet pozitif sayı giriniz...");

            }

            for (int i = 0; i < number20; i++)
            {
                Console.WriteLine(i + 1 + ".  sayıyı giriniz...");
                array20[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Sayılar başarıyla girildi şimdi bu girdiğiniz sayılardan 2. girdiğiniz sayıya eşit ve ona tam bölen olanlar: ");
            for (int k = 0; k < countOfArray20; k++)
            {
                if (array20[k] == number21 || number21 % array20[k] == 0)
                {
                    Console.WriteLine(array20[k]);
                }
                else
                {
                    continue;
                }
            }

        }
        static void Ornek3()
        {
            Console.WriteLine("3. UYGULAMA BAŞLANGICI...");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Bir adet pozitif sayı giriniz...");
            int number30 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number30 + " adet kelime giriniz.");
            string[] array30 = new string[number30];
            int countOfArray30 = array30.Count();
            for (int i = 0; i < countOfArray30; i++)
            {
                Console.WriteLine(i + 1 + ". kelimeyi giriniz...");
                array30[i] = Console.ReadLine();
            }
            Console.WriteLine("Girdiğiniz kelimelerin sondan başa sıralanmış hali:");

            for (int k = number30; k > 0; k--)
            {
                Console.WriteLine(array30[k - 1]);

            }
        }
        static void Ornek4()
        {
            string cumle = "";
            Console.WriteLine("4. UYGULAMA BAŞLANGICI.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Bir cümle yazınız...");
            cumle = Console.ReadLine().Trim();

            int harfSayisi = 0;
            int kelimeSayisi = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] != ' ')
                {
                    harfSayisi++;
                    if (i == cumle.Length - 1 || cumle[i + 1] == ' ')
                    {
                        kelimeSayisi++;
                    }
                }
            }

            Console.WriteLine("Harf Sayısı: " + harfSayisi);
            Console.WriteLine("Kelime Sayısı: " + kelimeSayisi);



        }
    }
}