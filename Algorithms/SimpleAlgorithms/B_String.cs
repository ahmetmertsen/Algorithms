using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    internal class B_String
    {
        public static void question1()
        {
            Console.WriteLine("Yazi: ");
            string yazi = Convert.ToString(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == ' ')
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }


        public static void question2()
        {
            Console.WriteLine("Yazı 1: ");
            string yazi1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Yazı 2: ");
            string yazi2 = Convert.ToString(Console.ReadLine());

            bool equals = false;
            for (int i = 0; i < yazi1.Length; i++)
            {
                if (yazi1.Length != yazi2.Length)
                {
                    equals = false;
                    break;
                }

                if (yazi1[i] == yazi2[i])
                {
                    equals = true;
                } else
                {
                    equals = false;
                    break;
                }
            }
            if (equals)
            {
                Console.WriteLine("Yazı eşittir.");
            } else
            {
                Console.WriteLine("Yazı eşit değildir.");
            }
        }


        public static void question3()
        {
            Console.WriteLine("Yazı: ");
            string yazi = Convert.ToString(Console.ReadLine());

            bool isBig = false;
            for (int i = 0; i < yazi.Length; i++)
            {
                int ascii = (int)yazi[i];
                if (ascii >= 65 && ascii <= 90)
                {
                    isBig = true;
                } else
                {
                    isBig = false;
                    break;
                }
            }
            if (isBig) 
            {
                Console.WriteLine("Yazıdaki harflerin hepsi  büyük yazılmıştır.");
            } else
            {
                Console.WriteLine("Yazıdaki harflerin hepsi büyük yazılmamıştır.");
            }
        }

        public static void question4()
        {
            Console.WriteLine("Yazı: ");
            string yazi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            string copy = "";
            for (int i = 1; i <= yazi.Length; i++)
            {
                if (i >= k && i <= r)
                {
                    copy += yazi[i-1];
                }
            }
            Console.WriteLine($"Kopyalanan yazı: {copy}");
        }

        public static void question5()
        {
            Console.WriteLine("Yazı: ");
            string yazi= Convert.ToString(Console.ReadLine());
            yazi += " ";

            int karakter = 0;
            int rakam = 0;
            int kelime = 0;
            for (int i = 0; i < yazi.Length; i++)
            {
                karakter++;
                int ascii = (int)yazi[i];
                if (ascii >= 48 && ascii <= 57)
                {
                    rakam++;
                }
                if (yazi[i] == ' ')
                {
                    kelime++;
                }
            }
            Console.WriteLine($"Karakter Sayısı: {karakter-1}\nRakam Sayısı: {rakam}\nKelime Sayısı: {kelime}");
        }
    }
}
