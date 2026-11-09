using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PopovAA.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            int num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        num += 1;
                    }
                }
            }
            return num;
        }
    }
}
