using System;

namespace _2020HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入指令:");
            string comd = Console.ReadLine();

            if (comd.Equals("add"))
            {
                int i, j, m, n;
                Console.WriteLine("Enter the Number of Rows and Columns : ");
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
                int[,] a = new int[m, n];

                Console.WriteLine("Enter the First Matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("First matrix is:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int[,] b = new int[m, n];
                Console.WriteLine("Enter the Second Matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Second Matrix is :");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Matrix add is:");
                int[,] c = new int[m, n];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                         c[i, j] = 0;
                         c[i, j] += a[i, j] + b[i, j];                       
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else if (comd.Equals("multiply"))
            {
                int i, j, m, n;
                Console.WriteLine("Enter the Number of Rows and Columns : ");
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
                int[,] a = new int[m, n];

                Console.WriteLine("Enter the First Matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("First matrix is:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int[,] b = new int[m, n];
                Console.WriteLine("Enter the Second Matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Second Matrix is :");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Matrix Multiplication is :");
                int[,] c = new int[m, n];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            else if (comd.Equals("print"))
            {
                int i, j, n;
                int[,] arr1 = new int[20, 20];

                n = 2;
                Console.Write("Enter elements in the matrix:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nThe matrix is:\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
            }
            else
            {
                Console.Write("please enter 'add' or 'multiply' or 'print'");
            }
        }
    }
}
