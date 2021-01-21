using System;

namespace _problemskiZadatak
{
    public static class Helper
    {
        public static bool IsNumeric(this Type type)
          => type == typeof(Int16) ||
            type == typeof(Int32) ||
            type == typeof(Int64) ||
            type == typeof(UInt16) ||
            type == typeof(UInt32) ||
            type == typeof(UInt64) ||
            type == typeof(float) ||
            type == typeof(double) ||
            type == typeof(decimal);
    }
    class NIOP
    {
        static void Main(string[] args)
        {
            // 2x4 matrix (2 rows 4 columns)
            int[,] m1 = { { 3, 7, 4, 0 },
                          { 1, 5, 2, 1} };

            // 4x2 (4 rows, 2 columns)
            int[,] m2 = { { 1, 2 },
                          { 3, 2 },
                          { 7, 1 },
                          { 14, -5} };

            int[,] multipliedMatrix = matrixMultiply(m1, m2);

            Console.WriteLine("Pomnozena matrica izgleda ovako: ");
            for (int i = 0; i < multipliedMatrix.GetLength(0); ++i)
            {
                for (int j = 0; j < multipliedMatrix.GetLength(1); ++j)
                {
                    Console.Write(multipliedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static T[,] matrixMultiply<T>(T[,] m1, T[,] m2)
        {
            if (!typeof(T).IsNumeric())
                throw new Exception("Incompatible data type for multiplication.");

            // If matrices are incompatible it will return an empty jagged array
            if (m1.GetLength(0) != m2.GetLength(1))
            {
                Console.WriteLine("Matrices aren't compatible for multiplication.");
                return new T[,] { };
            }

            int row_m1 = m1.GetLength(0), row_m2 = m2.GetLength(0);
            int col_m1 = m1.GetLength(1), col_m2 = m2.GetLength(1);

            T temp;
            T[,] matrix = new T[row_m1, col_m2];

            for (int i = 0; i < row_m1; ++i)
            {
                for (int j = 0; j < col_m2; ++j)
                {
                    temp = (dynamic)0;
                    for (int k = 0; k < col_m1; ++k)
                    {
                        temp += (dynamic)(m1[i, k]) * (dynamic)(m2[k, j]);
                    }
                    matrix[i, j] = temp;
                }
            }

            return matrix;
        }
    }
}
