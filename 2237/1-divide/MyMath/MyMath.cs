using System;
using System.Linq;

namespace MyMath
{
	/// <summary> Represents the different actions possible with a matrix.</summary>
	public static class Matrix
	{
		/// <summary>Divides all elements in <paramref name="matrix"/> by <paramref name="num"/>.</summary>
		/// <param name="matrix">Matrix to divide.</param>
		/// <param name="num">Integer to divide <paramref name="matrix"/> by.</param>
		/// <returns> The new matrix or null if <paramref name="matrix"/> is null.</returns>
		public static int[,] Divide(int[,] matrix, int num)
		{
			int[] matrixDivided;
			int[,] newMatrix;

			if (matrix == null)
				return null;

			try
			{
				matrixDivided = matrix.Cast<int>().Select(n => n / num).ToArray();
				newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
				Buffer.BlockCopy(matrixDivided, 0, newMatrix, 0, matrixDivided.Length * sizeof(int));
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Num cannot be 0");
				return null;
			}
			return newMatrix;
		}
	}
}
