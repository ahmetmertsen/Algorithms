using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public static void question27()
        {
            Console.WriteLine("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool isPronic = false;
            for (int i=1; i*(i+1)<=sayi; i++)
            {
                if (i*(i+1) == sayi)
                {
                    isPronic = true; 
                    break;
                }
            }
            if (isPronic == true) 
            {
                Console.WriteLine("Pronic sayıdır.");
            } else
            {
                Console.WriteLine("Pronic sayı değildir.");
            }
        }

        public static void question28()
        {
            Console.WriteLine("Sayı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int helper = sayi;

            int total = 0;
            while (sayi > 0)
            {
                total += sayi % 10;
                sayi = sayi / 10;
            }
            if (helper % total == 0)
            {
                Console.WriteLine("Harshard sayıdır.");
            } else
            {
                Console.WriteLine("Harshard sayı değildir.");
            }
        }

        public static void question29()
        {
            Console.WriteLine("Sayı Giriniz: ");
            string number = Convert.ToString(Console.ReadLine());

            bool isJumbled = true;
            for (int i = 0; i < number.Length-1; i++)
            {
                if (Math.Abs(number[i] - number[i+1]) > 1)
                {
                    isJumbled = false;
                    break;
                }
            }
            if (isJumbled == true)
            {
                Console.WriteLine("Jumbled Sayıdır.");
            } else
            {
                Console.WriteLine("Jumbled Sayı Değildir.");
            }
        }

        public static void question30()
        {
            Console.WriteLine("Sayı1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"En Büyük Ortak Bölen(OBEB): {OBEB(number1, number2)}");
            Console.WriteLine($"En Küçük Ortak Kart(OKEK): {OKEK(number1,number2)}");
        }
        public static int OBEB(int number1, int number2)
        {
            int kucukSayi = 0;
            int buyukSayi = 0;
            int ortakBolen = 0;
            if (number1 > number2)
            {
                kucukSayi = number2;
                buyukSayi = number1;
            }
            else
            {
                kucukSayi = number1;
                buyukSayi = number2;
            }

            for (int i = 1; i <= kucukSayi; i++)
            {
                if (kucukSayi % i == 0 && buyukSayi % i == 0)
                {
                    ortakBolen = i;
                }
            }
            return ortakBolen;
        }
        public static int OKEK(int number1, int number2)
        {
            int kucukSayi = 0;
            int buyukSayi = 0;
            int ortakKat = 0;
            if (number1 > number2)
            {
                kucukSayi = number2;
                buyukSayi = number1;
            }
            else
            {
                kucukSayi = number1;
                buyukSayi = number2;
            }

            for (int i=1; ;i++)
            {
                int buyukSayiKat = buyukSayi * i;
                if (buyukSayiKat % kucukSayi == 0)
                {
                    ortakKat = buyukSayiKat;
                    break;
                }
            }
            return ortakKat;
        }

        public static void question31()
        {
            Console.WriteLine("Hak Sayısı: ");
            int hak = Convert.ToInt32 (Console.ReadLine());

            int number = new Random().Next(1, 100);
            for (int i=hak-1; i>=0 ;i--)
            {
                Console.WriteLine("1-100 arası tahmin Giriniz: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Aşağı gidiniz...");
                } else if (guess < number) 
                {
                    Console.WriteLine("Yukarı gidiniz...");
                } else
                {
                    Console.WriteLine($"Sayıyı bildiniz... Sayı:{number}");
                    break;
                }
                if (i == 0)
                {
                    Console.WriteLine("Hakkınız Bitti, Oyunu Kaybettiniz...");
                }
            }
        }

        public static void quesiton32()
        {
            Console.WriteLine("Hak Sayısı: ");
            int hak = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            char harf = (char)random.Next('a', 'z' + 1);

            for (int i = hak - 1; i >= 0; i--)
            {
                Console.WriteLine("Harf Giriniz");
                char guess = Convert.ToChar(Console.ReadLine());

                if (guess == harf)
                {
                    Console.WriteLine($"Bildiniz... Harf:{harf}");
                    break;
                } else
                {
                    Console.WriteLine($"Bilemediniz... Kalan Hak:{i}");
                }
            }
        }

        public static void question33()
        {
            Console.WriteLine("X: ");
            float x = Convert.ToSingle(Console.ReadLine());

            float toplamYol = x;
            int sicramaSayisi = 0;

            while (x > 1)
            {
                x =  x * 0.8f;
                if (x < 1) { break; }

                toplamYol += 2 * x;
                sicramaSayisi += 1;
            }
            Console.WriteLine($"Toplam yol:{toplamYol}, Sıçrama Sayısı:{sicramaSayisi}");
        }

        public static void question34()
        {
            Console.WriteLine("Kenar Giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar Giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar Giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ( a+b>c && a+c>b && b+c>a)
            {
                Console.WriteLine("Üçgen çizilebilir.");
                if (a == b && b == c) { Console.WriteLine("Eşkenar Üçgen"); }
                else if (a == b || a == c || b == c) { Console.WriteLine("İkizkenar Üçgen"); }
                else if (a != b && a != c && b != c) { Console.WriteLine("Çeşitkenar Üçgen"); }

                int cevre = a + b + c;
                double s = (a + b + c) / 2;
                double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine($"Çevre:{cevre}, Alan:{alan}");
            }
            else
            {
                Console.WriteLine("Üçgen çizilemez...");
            }
        }

        public static void question35()
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> primeList = new List<int>();

            
            for(int j = 2; ;j++)
            {
                bool isPrime = true;
                for (int z=2;z<j;z++)
                {
                    if (j % z == 0)
                    {
                        isPrime = false; 
                        break;
                    } else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(j);
                }
                if (primeList.Count == n) { break; }
            }
            foreach (int i in primeList)
            {
                Console.WriteLine(i);
            }
        }

        public static void question36()
        {
            Console.WriteLine("Sayı: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int total = 1;
            for (int i = 1; number > total; i++)
            {
                total = total * i;
                if (total == number)
                {
                    Console.WriteLine($"{number} = {i}!");
                    break;
                } else if (total > number)
                {
                    Console.WriteLine("Sayı Faktöriyel bir sayı değil..");
                    break;
                }
            }
        }

        public static void question37(List<int> list)
        { 
            int count = 1;
            int maxNumber = 0;
            int maxCount = 0;
            List<int> numbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool varMi = false;
                for (int j =0; j < numbers.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        varMi = true;
                        break;
                    }
                }

                if (varMi) {
                    continue;
                } else
                {
                    numbers.Add(i);
                    for (int z = i+1; z < list.Count; z++)
                    {
                        if (list[i] == list[z])
                        {
                            count++;
                        }
                        
                    }
                    if (count > maxCount)
                    {
                        maxNumber = list[i];
                        maxCount = count;
                    }
                    count = 1;
                }
                
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != maxNumber) 
                {
                   Console.Write(list[i] + " "); 
                }
            }
        }

        public static void question38()
        {
            Console.WriteLine("Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int helperN = number;

            int total = 0;
            int helper = 0;
            while (helperN> 0) {
                helper = helperN % 10;

                int fak = 1;
                for (int j = helper; j > 0; j--)
                {
                    fak *= j;
                }
                total += fak;
                helperN = helperN / 10;
            }
            if (total == number)
            {
                Console.WriteLine($"{number} sayısı Güçlü Sayıdır.");
            } else
            {
                Console.WriteLine($"{number} sayısı Güçlü Sayı Değildir.");
            }
        }

        public static void question39()
        {
            Console.WriteLine("İfade Giriniz: ");
            string ifade = Convert.ToString(Console.ReadLine());

            string ters = "";
            for (int i=ifade.Length-1; i>=0; i--)
            {
                ters += ifade[i];
            }

            if (ifade == ters)
            {
                Console.WriteLine("İfade Palindrom");
            } else
            {
                Console.WriteLine("İfade Palindrom değil.");
            }
        }
 
    }
}
