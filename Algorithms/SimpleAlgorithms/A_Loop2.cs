using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    internal class A_Loop2
    {
        public static void question20()
        {
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
        {
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
        {
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
        {
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string stringNumber = number.ToString();

            for (int i = 0; i < stringNumber.Length; i++)
            {
                Console.Write("*" + " ");
            }
        }

        public static void question24()
        {
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
        {
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

        public static void question26()
        { 
            Console.WriteLine("Cümle: ");
            string cumle = Convert.ToString(Console.ReadLine());
            string harfler = "";
            int count = 1;

            for (int i=0; i<cumle.Length; i++)
            {
                if (!Char.IsLetter(cumle[i]))
                {
                    continue;
                }

                bool varMi=false;
                for (int j=0; j<harfler.Length; j++)
                {
                    if (cumle[i] == harfler[j])
                    {
                        varMi = true;
                        break;
                    }
                }

                if ( varMi == true)
                {
                    continue;
                }else
                {
                    harfler += cumle[i];
                    for (int z = i + 1; z < cumle.Length; z++)
                    {
                        if (cumle[i] == cumle[z])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Harf: {cumle[i]}, Adeti:{count}");
                count = 1;
            }
        }
    }
}
