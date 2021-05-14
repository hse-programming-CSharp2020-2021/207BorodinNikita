using System;


namespace Task_1
{
    class Matrix2
    {
        public double A11 { get; set; }

        public double A12 { get; set; }

        public double A21 { get; set; }

        public double A22 { get; set; }

        public Matrix2(double a11, double a12, double a21, double a22)
        {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }

        public Matrix2(double a11, double a22)
        {
            A11 = a11;
            A12 = 0;
            A21 = 0;
            A22 = a22;
        }

        public Matrix2(Matrix2 matrix2)
        {
            A11 = matrix2.A11;
            A12 = matrix2.A12;
            A21 = matrix2.A21;
            A22 = matrix2.A22;
        }

        public Matrix2() { }

        public static double Det(Matrix2 matrix2)
        {
            return matrix2.A11 * matrix2.A22 - matrix2.A12 * matrix2.A21;
        }

        public static Matrix2 Inverse(Matrix2 matrix2)
        {
            return Transpose(new Matrix2(matrix2.A22, -matrix2.A21, -matrix2.A12, matrix2.A11)) / Det(matrix2);
        }

        public static Matrix2 Transpose(Matrix2 matrix2)
        {
            return new Matrix2(matrix2.A11, matrix2.A21, matrix2.A12, matrix2.A22);
        }

        public static Matrix2 operator +(Matrix2 first, Matrix2 second)
        {
            return new Matrix2(first.A11 + second.A11, first.A12 + second.A12, first.A21 + second.A21, first.A22 + second.A22);
        }

        public static Matrix2 operator -(Matrix2 first, Matrix2 second)
        {
            return new Matrix2(first.A11 - second.A11, first.A12 - second.A12, first.A21 - second.A21, first.A22 - second.A22);
        }

        public static Matrix2 operator *(Matrix2 first, Matrix2 second)
        {
            Matrix2 result = new Matrix2()
            {
                A11 = first.A11 * second.A11 + first.A12 * second.A21,
                A12 = first.A11 * second.A12 + first.A12 * second.A22,
                A21 = first.A21 * second.A11 + first.A22 * second.A21,
                A22 = first.A21 * second.A12 + first.A22 * second.A22
            };

            return result;
        }

        public static Matrix2 operator /(Matrix2 first, Matrix2 second)
        {
            return first * Inverse(second);
        }

        public static Matrix2 operator *(Matrix2 matrix2, double value)
        {
            return new Matrix2(matrix2.A11 * value, matrix2.A12 * value, matrix2.A21 * value, matrix2.A22 * value);
        }

        public static Matrix2 operator /(Matrix2 matrix2, double value)
        {
            if (value == 0)
                throw new DivideByZeroException();

            return new Matrix2(matrix2.A11 / value, matrix2.A12 / value, matrix2.A21 / value, matrix2.A22 / value);
        }

        public static Matrix2 operator *(double value, Matrix2 matrix2)
        {
            return new Matrix2(matrix2.A11 * value, matrix2.A12 * value, matrix2.A21 * value, matrix2.A22 * value);
        }

        public override string ToString()
        {
            return $"{A11}\t{A12}\n{A21}\t{A22}";
        }

        public static bool operator true(Matrix2 matrix2)
        {
            return Det(matrix2) > 0;
        }

        public static bool operator false(Matrix2 matrix2)
        {
            return Det(matrix2) <= 0;
        }

        public static bool operator |(Matrix2 first, Matrix2 second)
        {
            return Det(first) > 0 | Det(second) > 0;
        }

        public static bool operator &(Matrix2 first, Matrix2 second)
        {
            return Det(first) > 0 & Det(second) > 0;
        }
    }
}