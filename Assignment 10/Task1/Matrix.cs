using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        private int[,] _matrix { get; set; }

        public Matrix(int[,] matrix)
        {
            _matrix = matrix;
        }

        public int[,] Matrixx
        {
            get
            {
                return _matrix;
            }
            set
            {
                _matrix = value;
            }
        }

        public static implicit operator Matrix(int[,] a)
        {
            return new Matrix(a);
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            const int length = 2;
            int[,] matrixSum = new int[2, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrixSum[i, j] = a._matrix[i, j] + b._matrix[i, j];
                }
            }
            return new Matrix(matrixSum);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            const int length = 2;
            int[,] matrixSum = new int[2, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrixSum[i, j] = a._matrix[i, j] - b._matrix[i, j];
                }
            }
            return new Matrix(matrixSum);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            const int length = 2;
            int[,] matrixMultiplied = new int[2, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < length; k++)
                    {
                        sum += a._matrix[i, k] * b._matrix[k, j];
                    }
                    matrixMultiplied[i, j] = sum;
                }
            }
            return new Matrix(matrixMultiplied);
        }

        public static Matrix operator -(Matrix a)
        {
            const int length = 2;
            int[,] matrixInversion = new int[2, 2];

            // Calculate Determinant
            int determinant = 1/(a._matrix[0, 0] * a._matrix[1, 1]) - (a._matrix[0, 1] * a._matrix[1, 0]);

            // Inversion Matrix
            int temp = a._matrix[0, 0];
            a._matrix[0,0] = a._matrix[1, 1];
            a._matrix[1,1] = temp;
            a._matrix[0, 1] = a._matrix[0, 1] * -1;
            a._matrix[1, 0] = a._matrix[1, 0] * -1;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrixInversion[i, j] =  determinant * a._matrix[i, j];
                }
            }
            return new Matrix(matrixInversion);
        }

        public override bool Equals(object obj)
        {
            Matrix matrix = (Matrix)obj;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (_matrix[i, j] != matrix._matrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output += _matrix[i, j] + " ";
                }
                output += "\n";
            }
            return output;
        }

        public void PrintMatrix()
        {
            const int length = 2;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
