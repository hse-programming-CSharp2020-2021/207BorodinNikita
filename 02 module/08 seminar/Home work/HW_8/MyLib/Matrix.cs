using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Matrix
    {
        private int[,] matrix;

        public int this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        public int Width
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public Matrix(int rows, int columns)
        {
            if (rows < 1 || columns < 1)
                throw new ArgumentOutOfRangeException("Values of rows and columns must be positive.");

            matrix = new int[rows, columns];
        }
    }
}
