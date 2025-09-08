using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms.loop
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            Array numbers = new[] {1,3,5,7,9,12,19,21 };
            //question1(numbers);
            //question2(numbers);
            //question3(numbers);
            //question4(10, 20);
            //question5();
            question6();

        }

        static void question1(Array array)
        { //Sayılar listesindeki hangi sayılar 3'ün katıdır ?
            foreach (int number in array)
            {
                if (number % 3 == 0) 
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void question2(Array array)
        { //Sayılar listesinde sayıların toplamı kaçtır?
            int total = 0;
            foreach (int number in array)
            {
                total += number;
            }
            Console.WriteLine(total);
        }

        static void question3(Array array)
        { // Sayılar listesindeki tek sayıların karesini alınız.
            foreach(int number in array)
            {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number*number);
                }
            }
        }

        static void question4(int start, int end)
        { // Başlangıç ve bitiş değelerini kullanıcadan alıp aradaki tüm tek sayıları ekrana yazdırın.
            for (int i = start; i<end; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void question5()
        { //1-100 arasındaki sayıları azalan şekilde yazdırın.
            for (int i=99; i>1;i--)
            {
                Console.WriteLine(i);
            }
        }

        static void question6()
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



    }
}
