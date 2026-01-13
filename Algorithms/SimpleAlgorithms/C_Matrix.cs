using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    internal class C_Matrix
    {
        public static void question1()
        {
            Console.Write("M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris[i,j] = 0;
                    Console.Write(matris[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void question2()
        {
            #region Matrix oluşturma
            int[,] matris1 = new int[3, 3];
            int[,] matris2 = new int[3, 3];

            Random rand = new Random();
            int min = 1, max = 10; // 1-9 arası

            for (int i = 0; i < 3; i++)
            {
               for (int j = 0;j < 3; j++)
               {
                    matris1[i,j] = rand.Next(min,max);
                    Console.Write(matris1[i, j] + " ");
                }
               Console.WriteLine("");
            }
            Console.WriteLine("---------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris2[i, j] = rand.Next(min, max);
                    Console.Write(matris2[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---------------");
            #endregion

            #region Matrix toplama
            int[,] matris3 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris3[i, j] = matris1[i, j] + matris2[i, j];
                    Console.Write(matris3[i, j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion
        }

        public static void question3()
        {
            #region Matrix Oluşturma
            Random rand = new Random();
            int min = 1, max = 10;

            int[,] matris = new int[5, 5];
            for (int i = 0;i < 5;i++)
            {
                for (int j = 0;j < 5;j++)
                {
                    matris[i,j] = rand.Next(min,max);
                    Console.Write(matris[i,j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion

            Console.WriteLine("---------------");

            #region Matrix'in satır ve sütun toplamı
            int satirToplam = 0;
            int sutunToplam = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    satirToplam += matris[i,j];
                }
                Console.WriteLine($"{i+1}. Satır Toplam: {satirToplam}");
                satirToplam = 0;
            }

            Console.WriteLine("---------------");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sutunToplam += matris[j, i];
                }
                Console.WriteLine($"{i+1}. Sütun Toplam: {sutunToplam}");
                sutunToplam = 0;
            }
            #endregion
        }

        public static void question4()
        {
            #region Matrix oluşturma
            Console.Write("M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[m, n];

            Random rand = new Random();
            int min = 1, max = 100;

            for (int i = 0;i < m; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    matris[i,j] = rand.Next(min,max);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion

            #region Matrixteki en büyük sayı
            int maxNumber = 0;
            for (int i = 0; i<m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (matris[i,j] > maxNumber)
                    {
                        maxNumber = matris[i,j];
                    }
                }
            }
            Console.WriteLine($"En Büyük Sayı: {maxNumber}");
            #endregion
        }


        public static void question5()
        {
            int[,] matris = new int[5, 5];

            Random rand = new Random();
            int min = 1, max = 10;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = rand.Next(min, max);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine("");
            }

            int matrisIzi = 0;
            for(int i = 0;i < 5; i++)
            {
                for(int j = 0; j<5;j++)
                {
                    if (i == j)
                    {
                        matrisIzi += matris[i, j];
                    }
                }
            }
            Console.Write($"Matris İzi: {matrisIzi}");
        }

        public static void question6()
        {
            int[,] matris = new int[5, 5];

            Random rand = new Random();
            int min = 1, max = 10;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = rand.Next(min, max);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---------------");

            Console.Write("k (0-24 arası indeks): ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yerleştirelecek Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int cols = matris.GetLength(1);
            int row = k / cols;
            int col = k % cols;

            matris[row, col] = sayi;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(matris[i, j] + " ");
                Console.WriteLine();
            }
        }

        public static void question7()
        {
            int[,] matris = new int[5, 5];

            Random rand = new Random();
            int min = 1, max = 10;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = rand.Next(min, max);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---------------");

            int[,] transpoz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    transpoz[j, i] = matris[i, j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(transpoz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
