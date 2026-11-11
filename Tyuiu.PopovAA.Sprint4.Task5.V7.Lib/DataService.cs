using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PopovAA.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int cnt = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        cnt += 1;
                    }
                }
            }
            return cnt;
        }
    }
} 
