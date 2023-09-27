using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_09_23
{
    class Matrix2D<T>
    {
        private T[,] data;

        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public T[,] Arr
        {
            get { return data; }
            set { data = value; }
        }

        public int Size
        {
            get { return Rows * Columns; }
        }

        public Matrix2D(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new T[rows, columns];
        }

        public T this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        public static Matrix2D<T> operator +(Matrix2D<T> matrix1, Matrix2D<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions for addition.");
            }

            Matrix2D<T> result = new Matrix2D<T>(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    dynamic value1 = matrix1[i, j];
                    dynamic value2 = matrix2[i, j];
                    result[i, j] = value1 + value2;
                }
            }
            return result;
        }
    }
}
