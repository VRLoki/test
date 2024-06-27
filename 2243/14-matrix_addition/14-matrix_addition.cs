using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Adds two matrixes together.
	/// </summary>
	/// <param name="matrix1">2D or 3D matrix</param>
	/// <param name="matrix2">2D or 3D matrix</param>
	/// <returns>A matrix containing -1 or the result.</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		int matrixCheck1 = CheckMatrix(matrix1), matrixCheck2 = CheckMatrix(matrix2);

		if ((matrixCheck1 != 2 && matrixCheck1 != 3) || (matrixCheck2 != 2 && matrixCheck2 != 3) || (matrixCheck1 != matrixCheck2))
			return new double[,] { { -1 } };

		int lengthRow = matrix1.GetLength(0);
		int lengthColumn = matrix1.GetLength(1);
		double[,] sum = new double[lengthRow, lengthColumn];

		for (int i = 0; i < lengthRow; i++)
		{
			for (int j = 0; j < lengthColumn; j++)
				sum[i, j] = matrix1[i, j] + matrix2[i, j];
		}
		return sum;
	}

	/* Check if a matrix is 2D, 3D or anything else */
	private static int CheckMatrix(double[,] matrix)
	{
		int length = matrix.GetLength(0);

		if (length != 2 && length != 3)
			return -1;

		if (matrix.GetLength(1) != length)
			return -1;

		return length;
	}
}
