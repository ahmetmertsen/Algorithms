using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    internal class A_Loop
    {
        public static void question1(int[] numbers)
        { //Sayılar listesindeki hangi sayılar 3'ün katıdır ?
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void question2(int[] numbers)
        { //Sayılar listesinde sayıların toplamı kaçtır?
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            Console.WriteLine(total);
        }

        public static void question3(int[] numbers)
        { // Sayılar listesindeki tek sayıların karesini alınız.
            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number * number);
                }
            }
        }

        public static void question4(int start, int end)
        { // Başlangıç ve bitiş değelerini kullanıcadan alıp aradaki tüm tek sayıları ekrana yazdırın.
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void question5()
        { //1-100 arasındaki sayıları azalan şekilde yazdırın.
            for (int i = 99; i > 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void question6()
        { // Kullanıcıdan alacağınız 5 sayıyı ekranda sıralı bir şekilde yazdırın.
            List<int> numbers = new List<int>();
            Console.WriteLine("5 Sayı Giriniz: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sayı {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            //Sıralama
            for (int i = 0; i < numbers.Count; i++)
            {
                int helper = 0;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        helper = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = helper;
                    }
                }
            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }


        public static void question7()
        { // 1-100 arasında rastgele üretilecek bir sayıyı aşağı yukarı ifadeleri ile buldurmaya çalışın. (hak = 5)
          // **"random modülü"
          // **100 üzerinden puanlama yapın.Her soru 20 puan.
          // **Hak bilgisini kullanıcdan alın ve her soru belirtilen can sayısı üzerinden hesaplansın.
            Console.WriteLine("Hak Sayısı: ");
            int numberOfRight = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int number = random.Next(1, 101);

            int point = 100;
            int oneQuestion = point / numberOfRight;

            for (int i = numberOfRight; i > 0; i--)
            {
                Console.Write($"Tahmin Giriniz: ");
                int quess = Convert.ToInt32(Console.ReadLine());
                point -= oneQuestion;

                if (quess > number)
                {
                    Console.WriteLine("Aşağı gidiniz...");
                    Console.WriteLine($"Kalan Puan: {point} ");
                }
                else if (quess < number)
                {
                    Console.WriteLine("Yukarı gidiniz...");
                    Console.WriteLine($"Kalan Puan: {point} ");
                }
                else
                {
                    Console.WriteLine($"Bildiniz! Puan:{point} -> Sayı:{number} ");
                    break;
                }
                if (point == 0)
                {
                    Console.WriteLine("Puanınınz 0'landı. Kaybettiniz...");
                    break;
                }
            }
        }

        public static void question8()
        { // Girilen bir sayının asal olup olmadığını bulun.
          // **Asal sayı 1 ve kendisi hariç tam böleni olmayan sayılara denir.
            Console.WriteLine("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
                else
                {
                    IsPrime = true;
                }
            }
            if (IsPrime == true)
            {
                Console.WriteLine($"{number} Sayısı Asaldır.");
            }
            else
            {
                Console.WriteLine($"{number} Sayısı Asal Değildir.");
            }

        }

        public static void question9()
        { // Girilen sayıların ortalamasını bulan program.
            int total = 0;
            Console.WriteLine("Kaç Sayının Ortalamasını Bulmak İstiyorsunuz?");
            int numbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                total += number;
            }
            int avarage = total / numbers;
            Console.WriteLine($"Ortalama: {avarage}");

        }

        public static void question10()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            { //Girilen 5 sayı içerisindeki minimum ve maksimum değerleri bulan program?
                Console.WriteLine("Sayı: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Min:{min}, Max:{max}");
        }

        public static void question11()
        { //N’e kadar tek sayıları yazdıran program?
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void question12()
        { //Girilen sayının tam bölenlerini bulan program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void question13()
        {// Girilen sayının tam bölenlerinin sayısını bulan program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Tam Bölenlerin Sayısı:{count}");
        }


        public static void question14()
        { // n’e kadar ki tek sayıların toplamı, çift sayıların çarpımını hesaplayan program?
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int multi = 1;

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    total += i;
                }
                if (i % 2 == 0)
                {
                    multi *= i;
                }
            }
            Console.WriteLine($"Tek Sayıların Toplamı:{total}, Çift Sayıların Çarpımı:{multi}");
        }

        public static void question15()
        { // Girilen sayının faktöriyelini hesaplayan program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fak = 1;
            for (int i = 1; i <= number; i++)
            {
                fak *= i;
            }
            Console.WriteLine($"Faktöriyel:{fak}");
        }

        public static void question16()
        { // Girilen n değerine göre Fibonacci serisinin ( 0 1 1 2 3 5 8 … ) ilk n terimini hesaplayınız?
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }

        public static void question17()
        { // Girilen n adet sayı içerisinden pozitif, negatif ve sıfır sayısının kaçar adet tekrarlandığını bulan program?
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int pozitif = 0;
            int negatif = 0;
            int sifir = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    negatif += 1;
                }
                if (sayi > 0)
                {
                    pozitif += 1;
                }
                if (sayi == 0)
                {
                    sifir += 1;
                }
            }
            Console.WriteLine($"Pozitif Sayısı:{pozitif}, Negatif Sayısı:{negatif}, Sıfır Sayısı:{sifir}");
        }

        public static void question18()
        { // Serinin ilk elemanı, toplam eleman sayısını ve artış değeri girildiğinde seri sonucunu hesaplayan program?
            Console.WriteLine("İlk Eleman: ");
            int ilkEleman = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam Eleman: ");
            int toplamEleman = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artış Değeri: ");
            int artis = Convert.ToInt32(Console.ReadLine());

            int helper = ilkEleman;
            for (int i = 0; i < toplamEleman; i++)
            {
                Console.Write(helper + " ");
                helper += artis;
            }
        }

        public static void question19()
        { // Girilen bir sayının asal çarpanlarını bulan program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int helper = number;
            List<int> list = new List<int>();
            for (int i = 2; i <= helper; i++)
            {
                /* İlk denediğim yol (doğru ama uzun)
                for (int j=0;  j<helper; j++)
                {
                    if (helper % i == 0)
                    {
                        helper = helper / i;
                        list.Add(i);
                    }
                    else
                    {
                        break;
                    }
                }
                */

                while (helper % i == 0)
                {
                    list.Add(i);
                    helper /= i;
                }
            }
            Console.Write($"{number}'ın asal çarpanları: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        public static void question20()
        { // Girilen sayının basamak değerleri çarpımını bulunuz?

            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string stringNumber = number.ToString();
            int result = 1;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                int rakam = stringNumber[i] - '0';
                result *= rakam;
            }
            Console.WriteLine($"{number} basamak değerleri çarpımı: {result}");

        }

        public static void question21()
        { // Girilen sayının basamak değerlerinde k rakamı olmayanları listeleyen program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k: ");
            char k = Convert.ToChar(Console.ReadLine());
            string stringNumber = number.ToString();

            List<char> list = new List<char>();

            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (stringNumber[i] != k)
                {
                    list.Add(stringNumber[i]);
                }
            }
            foreach (char i in list)
            {
                Console.Write(i + " ");
            }
        }

        public static void question22()
        { // Girilen sayının basamak sayısını ekrana yazdıran program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string stringNumber = number.ToString();
            int result = 0;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                result += 1;
            }
            Console.WriteLine($"Basamak Sayısı: {result}");
        }

        public static void question23()
        { // Girilen sayının basamak değerleri kadar yıldızı yan yana yazdıran program?
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string stringNumber = number.ToString();

            for (int i = 0; i < stringNumber.Length; i++)
            {
                Console.Write("*" + " ");
            }
        }

        public static void question24()
        { //Girilen cümleyi tersten yazdırın
            Console.WriteLine("Cümle: ");
            string cumle = Convert.ToString(Console.ReadLine());

            string tersCumle = "";
            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                tersCumle += cumle[i];
            }
            Console.WriteLine($"Ters Cümle: {tersCumle}");
        }

        public static void question25()
        { //Girilen cümledeki sesli ve sessiz harf sayısını bulun.
            Console.WriteLine("Cümle: ");
            string cumle = Convert.ToString(Console.ReadLine());
            char[] sesliHarfler = { 'A', 'a', 'E', 'e', 'I', 'ı', 'İ', 'i', 'O', 'o', 'Ö', 'ö', 'U', 'u', 'Ü', 'ü' };

            int sesliHarflerSayisi = 0;
            int helper = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (!Char.IsLetter(cumle[i]))
                {
                    helper++;
                }
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (cumle[i] == sesliHarfler[j])
                    {
                        sesliHarflerSayisi++;
                    }
                }
            }
            Console.WriteLine($"Sesli Harf Sayısı:{sesliHarflerSayisi}, Sessiz Harf Sayısı:{(cumle.Length - helper) - sesliHarflerSayisi}");
        }
    }
}
