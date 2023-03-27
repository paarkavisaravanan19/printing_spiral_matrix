using System;
namespace ConsoleApplication
{
    public class spiral_matrix
    {
        //class that creates matrix into spiral order
        public void SpiralOrder(int m, int n, int[,] matrix)
        {
            int i, k = 0, l = 0;
            while (k < m && l < n)
            {
                for (i = l; i < n; ++i)
                {
                    Console.Write(matrix[k, i] + " ");
                }
                k++;
                for (i = k; i < m; ++i)
                {
                    Console.Write(matrix[i, n - 1] + " ");
                }
                n--;
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(matrix[m - 1, i] + " ");
                    }
                    m--;
                }
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(matrix[i, l] + " ");
                    }
                    l++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            spiral_matrix m = new spiral_matrix();
            int R = 3;
            int C = 6;
            Console.WriteLine("the given matrix");
            /*
            //user input
            int[,] aa = new int[3,6];
            int count;
            for (int i=0; i<R; ++i)
            {
                for(int j=0;j<C;j++)
                {
                    aa[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            */
            //provided matrix
            int[,] matrix = { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 } };
            //printing of matrix
            for (int i = 0; i < R; ++i)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Spiral order of the matrix: ");
           //int[,] aa = { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 },{ 13, 14, 15, 16, 17, 18 } };
            m.SpiralOrder(R, C, matrix);
        }
    }
}