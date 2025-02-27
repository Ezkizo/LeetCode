using System.ComponentModel;

namespace pruebasLeetCode;
public class _54_SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int bottom = matrix.Length - 1, right = matrix[0].Length - 1;
        int top = 0, left = 0;
        if (bottom is 0)
            return matrix[0];
        List<int> res = new();
        if (right is 0)
        {
            for (int i = top; i <= bottom; i++) 
            {
                res.Add(matrix[i][left]);
            }
            return res;
        }
        while (top <= bottom && left <= right)
        {
            //Izquierda a derecha
            for (int index = left; index <= right; index++)
            {
                res.Add(matrix[top][index]);
            }
            top++;

            //Arriba a abajo desde la derecha
            for (int index = top; index <= bottom; index++)
            {
                res.Add(matrix[index][right]);
            }
            right--;
            //Izquierda a derecha desde última fila
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    res.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            //Abajo a arriba
            if (top < bottom)
            {
                for (int i = bottom; i >= top; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
         }
        return res;
    }
}
