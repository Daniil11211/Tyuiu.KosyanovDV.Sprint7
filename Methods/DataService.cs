using System.Linq;

namespace Methods;

public class DataService
{
    public int[] GetArrayColumn(string[,] matrix, int c)
    {
        int columns = matrix.GetLength(0);
        int[] arrayColumn = new int[columns];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            arrayColumn[i] = Convert.ToInt32(matrix[i, c]);
        }
        return arrayColumn;
    }

    public double CalcAverageValue(int[] array, int n)
    {
        double amount = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
            amount++;
        }

        return Math.Round((sum/amount), n);
    }

    public int CalcMax(int[] array)
    {
        return array.Max();
    }

    public int CalcMin(int[] array)
    {
        return array.Min();
    }
    
    public int CalcSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }
}
