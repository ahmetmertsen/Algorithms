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
        //16 bakılacak, 19 ve 20 tek ve çift durumuna göre farklı çıkıyor.Tekrardan bak!

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

        public static void question15(int n)
        {
            for (int i = 1; i<=n/2; i++)
            {
                for (int j=1; j<i; j++)
                {
                    Console.Write("  ");
                }
                for(int z=1; z<=n/2+1-i;z++)
                {
                    Console.Write("* ");
                }
                for(int t=1; t<=n/2-i; t++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            for(int i = 1; i<=n/2;i++)
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
        }

        public static void question16(int n)
        { //Daha sonra bak.
            for(int i = 2; i<=n/2+1;i +=2)
            {
                for(int j=1; j<n/2-i; j+=2)
                {
                    Console.Write("  ");
                }
                for(int z=1; z<=i; z++)
                {
                    Console.Write("* ");
                }
                for(int t=i; t >= 0; t--)
                {
                    Console.Write("  ");
                }
                for(int x=1; x<=i; x++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }

        public static void question17(int n)
        {
            for(int i=1; i<=n;  i++)
            {
                for(int j=1; j<=n;j++)
                {
                    if(i == 1 || i == n)
                    {
                        Console.Write("* ");
                    } else
                    {
                        if(j == 1 || j == n)
                        {
                            Console.Write("* ");
                        } else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void question18(int n)
        {
            for(int i=1; i<=n;i++)
            {
                for (int j=1; j<n*2; j++)
                {
                    if (j+i == n+1 || j-i==n-1)
                    {
                        Console.Write("* ");
                    } else
                    {
                        if(i==n)
                        {
                            Console.Write("* ");
                        } else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void question19(int n)
        {
            int orta;
            if (n%2==0)
            {
                orta = n/2;
            }
            else
            {
                orta = n/2+1;
            }
            for (int i = 1; i <= orta; ++i)
                {
                    for (int j = 1; j < n; j++)
                    {
                        if (j + i == orta+1 || j-i == orta-1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            for(int i=1; i<=orta-1; i++)
            {
                for(int j=1; j<=2*orta-1; j++)
                {
                    if (j+i == 2*orta-1 || j-i==1)
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void question20(int n)
        {
            for(int i=1; i<=n/2;i++)
            {
                for(int j=1; j<n;j++)
                {
                    if(j+i==n || j-i==0 || i==1)
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for(int i=1; i<=n/2-1;i++)
            {
                for(int j=1; j<n; j++)
                {
                    if (j+i==n/2 || j-i==n/2 || i==n/2-1)
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            
        }

    }
}
