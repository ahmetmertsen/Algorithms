using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms.loop
{
    internal class Loop
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
            foreach(int number in numbers)
            {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number*number);
                }
            }
        }

        public static void question4(int start, int end)
        { // Başlangıç ve bitiş değelerini kullanıcadan alıp aradaki tüm tek sayıları ekrana yazdırın.
            for (int i = start; i<end; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void question5()
        { //1-100 arasındaki sayıları azalan şekilde yazdırın.
            for (int i=99; i>1;i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void question6()
        { // Kullanıcıdan alacağınız 5 sayıyı ekranda sıralı bir şekilde yazdırın.
            List<int> numbers = new List<int>();
            Console.WriteLine("5 Sayı Giriniz: ");
            for (int i=0; i<5;i++)
            {
                Console.WriteLine($"Sayı {i+1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            //Sıralama
            for (int i=0; i<numbers.Count; i++)
            {
                int helper = 0;
                for (int j=i+1;  j<numbers.Count; j++)
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
   
            for (int i=2; i<number; i++)
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
              
            for (int i=0; i<numbers;i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                total += number;
            }
            int avarage = total / numbers;
            Console.WriteLine($"Ortalama: {avarage}");

        }

    }
}
