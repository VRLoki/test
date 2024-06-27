using System;
using System.Linq;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        /* Create an array containing the square value of all integers inside myMatrix */
        int[] squaredMatrix = myMatrix.Cast<int>().Select(n => n * n).ToArray();
        /* Create a new matrix of the same size as the original one */
        int[,] newMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        /* Copy all bytes from squaredMatrix to newMatrix */
        Buffer.BlockCopy(squaredMatrix, 0, newMatrix, 0, squaredMatrix.Length * sizeof(int));
        return newMatrix;
    }
}
