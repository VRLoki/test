using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Shears a matrix in a given direction with a factor.
	/// </summary>
	/// <param name="matrix">2D matrix to shear</param>
	/// <param name="direction">X or Y</param>
	/// <param name="factor">Factor to shear the matrix to</param>
	/// <returns>A matrix with -1 inside or the result </returns>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		if ((matrix.GetLength(0) != matrix.GetLength(1)) || (direction != 'x' && direction != 'y'))
			return new double[,] { { -1 } };

		double[,] shearMatrix = GetShearMatrix(direction, factor);

		return Multiply(matrix, shearMatrix);
	}

	/* Gets the shear matrix for the direction given. */
	private static double[,] GetShearMatrix(char direction, double factor)
	{
		switch (direction)
		{
			case 'x':
				return new double[,]
				{
					{1, 0},
					{factor, 1}
				};
			case 'y':
				return new double[,]
				{
					{1, factor},
					{0, 1}
				};
			default:
				return new double[,] { { -1 } };
		}
	}

	/* Multiplies 2 matrixes. */
	private static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int rowMatrix1 = matrix1.GetLength(0);
		int colMatrix1 = matrix1.GetLength(1);
		int rowMatrix2 = matrix2.GetLength(0);
		int colMatrix2 = matrix2.GetLength(1);

		if (colMatrix1 != rowMatrix2)
			return new double[,] { { -1 } };

		double[,] mul = new double[rowMatrix1, colMatrix2];

		for (int i = 0; i < rowMatrix1; i++)
		{
			for (int j = 0; j < colMatrix2; j++)
			{
				double temp = 0;
				for (int k = 0; k < colMatrix1; k++)
					temp += matrix1[i, k] * matrix2[k, j];
				mul[i, j] = Math.Round(temp, 2);
			}
		}
		return mul;
	}
}
