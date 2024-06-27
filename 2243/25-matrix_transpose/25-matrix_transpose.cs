using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Transposes a matrix.
	/// </summary>
	/// <param name="matrix">Matrix to transpose.</param>
	/// <returns>An empty matrix or the matrix transposed.</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		if (matrix.Length == 0)
			return new double[,] { };

		int rowLength = matrix.GetLength(0);
		int colLength = matrix.GetLength(1);

		double[,] transposedMatrix = new double[colLength, rowLength];

		for (int i = 0; i < rowLength; i++)
		{
			for (int j = 0; j < colLength; j++)
			{
				transposedMatrix[j, i] = matrix[i, j];
			}
		}
		return transposedMatrix;
	}
}
