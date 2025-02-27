namespace pruebasLeetCode;
public class _48_RotateImage
{
    /*
    Clockwise rotate a matrix n x n 
    Rotate by 90 degrees
    Input  [[1,2,3],
            [4,5,6],
            [7,8,9]]
    Output: [[7,4,1]
            ,[8,5,2]
            ,[9,6,3]]
    Approaches 
    1. Take columns into files and rewrite matrix swapping them
    2. Take positions and reordenate them
    3. Is there an algorithm actually design for this?
    */
    public void Rotate(int[][] matrix)
    {
        //Solución IA
        //int n = matrix.Length;

        //// Transponer la matriz
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = i; j < n; j++)
        //    {
        //        int temp = matrix[i][j];
        //        matrix[i][j] = matrix[j][i];
        //        matrix[j][i] = temp;
        //    }
        //}

        //// Invertir cada fila
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n / 2; j++)
        //    {
        //        int temp = matrix[i][j];
        //        matrix[i][j] = matrix[i][n - 1 - j];
        //        matrix[i][n - 1 - j] = temp;
        //    }
        //}


        #region Mi solución
        var n = matrix.Length - 1;
        List<int> help = new();
        int left = 0;
        int helperIndex = n;
        int helperPointer = 0;
        for (int i = 0; i <= n; i++)
        {
            if (left > n)
                break;
            help.Add(matrix[i][left]);
            if (i == n)
            {
                i = -1;
                helperIndex = n;
                helperPointer++;
                left++;
            }
        }
        left = n;
        helperIndex = 0;
        foreach (int val in help)
        {
            if (left < 0)
            {
                left = n;
                helperIndex++;
            }
            matrix[helperIndex][left] = val;
            left--;
        }
        #endregion Mi solución
    }

}
