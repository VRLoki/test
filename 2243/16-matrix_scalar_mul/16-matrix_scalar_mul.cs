using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply a matrix by a scalar.
    /// </summary>
    /// <param name="matrix">2D/3D matrix to multiply</param>
    /// <param name="scalar">Scalar to multiply the matrix</param>
    /// <returns>A matrix containing -1 or the result of the multiplication.</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		int matrixChecked = CheckMatrix(matrix);

		if (matrixChecked != 2 && matrixChecked != 3)
			return new double[,] { { -1 } };

		for (int i = 0; i < matrix.GetLength(0); i++)
        {
			for (int j = 0; j < matrix.GetLength(1); j++)
				matrix[i, j] *= scalar;
		}
		return matrix;
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
