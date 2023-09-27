using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_09_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix2D<int> matrix1 = new Matrix2D<int>(2, 2);
            Matrix2D<int> matrix2 = new Matrix2D<int>(2, 2);

            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            Matrix2D<int> sumMatrix = matrix1 + matrix2;
            

            Console.WriteLine("Sum of matrices:");
            for (int i = 0; i < sumMatrix.Rows; i++)
            {
                for (int j = 0; j < sumMatrix.Columns; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }







}

