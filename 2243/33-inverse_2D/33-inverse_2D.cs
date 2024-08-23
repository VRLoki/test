using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
static class MatrixMath
{
    /// <summary>
    /// Inverts a 2D matrix.
    /// </summary>
    /// <param name="matrix">Matrix to invert</param>
    /// <returns>A matrix with -1 if it's a singular matrix or not a 2D matrix or the inverted matrix.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2)
            return new double[,] { { -1 } };

        double determinant = Determinant(matrix);

        if (determinant == 0)
            return new double[,] { { -1 } };

        matrix[1, 0] = -matrix[1, 0];
        matrix[0, 1] = -matrix[0, 1];
        (matrix[1, 1], matrix[0, 0]) = (matrix[0, 0], matrix[1, 1]);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                matrix[i, j] = Math.Round(matrix[i, j] / determinant, 2);
        }
        return matrix;
    }

    /* Calculates the determinant of a 2D matrix. */
    private static double Determinant(double[,] matrix) => Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
}
