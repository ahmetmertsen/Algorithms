using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    internal class A_Loop3_shapes
    {

        public static void q()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i*j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void question1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void question2(int n)
        {
            for(int i = 0;i < n; i++)
            {
                for (int j=0; j<i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void question3(int n)
        {
            for (int i=0; i<n; i++)
            {
                for (int j=1; j<=i+1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void question4(int n)
        {
            for(int i=0; i<=n;  i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void question5(int n)
        {
            for (int i=n-1; i>0; i--)
            {
                for(int j=i; j>0;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            for (int i=0; i<n-1; i++)
            {
                for (int j=0; j<i+1;j++)
                {
                    Console.Write(i+1);
                }
                Console.WriteLine();
            }
        }

        public static void question6(int n)
        {
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }

        public static void question7(int n)
        {
            int counter = 1;
            for (int i = 0;i < n; i++)
            {
                for (int j=0; j<n;j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }

        public static void quesiton8(int n)
        {
            for (int i=0; i<n;i++)
            {
                for(int j=0; j<2*n; j++)
                {
                    if (j+i == n || j-i== n)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void quesiton9(int n)
        {
            for (int i=1;i<=n;i++)
            {
                for (int j=1; j<=n-i;j++)
                {
                    Console.Write("  ");
                }
                for (int z=1; z<=i; z++)
                {
                    Console.Write("* ");
                }
                for (int t = 1; t < i; t++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void question10(int n)
        {
            for (int i=1; i<=n;i++)
            {
                for(int j=1; j<i;j++)
                {
                    Console.Write("  ");
                }
                for(int z=1; z<=n+1-i;z++)
                {
                    Console.Write("* ");
                }
                
                for(int t=1; t<=n-i; t++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }

        public static void question11(int n)
        {
            for (int i = 1; i <= n/2; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i=n/2-1; i>=1; i--)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void question12(int n)
        {
            for (int i=1; i<=n/2; i++)
            {
                for (int j=1;j<=n/2-i; j++)
                {
                    Console.Write("  ");
                }
                for (int z=1;z<=i;z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i=1;i<=n/2-1;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write("  ");
                }
                for(int z=1;z<=n/2-i;z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void question13(int n)
        {
            for(int i=1;i<=n/2;i++)
            {
                for(int j=1; j<=n/2-i;j++)
                {
                    Console.Write("  ");
                }
                for(int z=1; z<=i; z++)
                {
                    Console.Write("* ");
                }
                for(int t=1; t<i; t++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int i=1; i<=n/2-1;i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("  ");
                }
                for(int z=1; z<=(n/2)-i;z++)
                {
                    Console.Write("* ");
                }
                for(int t=1; t<=(n/2-1)-i;t++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void question14(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                for (int z = 1; z <= (n / 2) - i; z++)
                {
                    Console.Write("  ");
                }
                for (int t = 1; t <= (n / 2 - 1) - i; t++)
                {
                    Console.Write("  ");
                }
                for (int x = 1; x <= i; x++)
                {
                    if (i == n/2 && x == n/2)
                    {
                        continue;
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int i=1; i<=n/2-1; i++)
            {
                for(int j=1; j<=n/2-i;j++)
                {
                    Console.Write("* ");
                }
                for(int z=1; z<=i;z++)
                {
                    Console.Write("  ");
                }
                
                for (int t = 1; t < i; t++)
                {
                    Console.Write("  ");
                }
                for (int x=1; x<=(n/2)-i;  x++)
                {
                    Console.Write("* ");
                }
                 
                Console.WriteLine();
            }
        }

    }
}
