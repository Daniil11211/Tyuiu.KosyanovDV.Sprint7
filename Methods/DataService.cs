using System.Linq;

namespace Methods;

public class DataService
{
    public int[] GetArrayColumn(string[,] matrix, int columnIndex)
    {
        int rows = matrix.GetLength(0);

        if (rows <= 2)
        {
            return new int[0];
        }

        int newSize = rows - 2;
        int[] resultArray = new int[newSize];

        for (int i = 1; i < rows - 1; i++)
        {
            resultArray[i - 1] = Convert.ToInt32(matrix[i, columnIndex]);
        }

        return resultArray;
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
