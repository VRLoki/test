using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Calculates the determinant of a 2D or 3D matrix.
	/// </summary>
	/// <param name="matrix">2D or 3D matrix</param>
	/// <returns>-1 or the determinant.</returns>
	public static double Determinant(double[,] matrix)
	{
		int matrixChecked = CheckMatrix(matrix);

		if (matrixChecked != 2 && matrixChecked != 3)
			return -1;

		if (matrixChecked == 2)
			return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);

		double n1 = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
		double n2 = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
		double n3 = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
		return Math.Round(n1 - n2 + n3, 2);
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
