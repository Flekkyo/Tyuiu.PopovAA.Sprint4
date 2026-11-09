using Tyuiu.PopovAA.Sprint4.Task3.V15.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (статический ввод)                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 7, 4, 2, 5, 3 },
                             { 4, 3, 2, 5, 6 }, 
                             { 6, 3, 4, 7, 5 }, 
                             { 5, 7, 4, 3, 8 }, 
                             { 7, 8, 8, 5, 6 } };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < 4)
                    {
                        Console.Write(array[i, j] + ", ");
                    }

                    else
                    {
                        Console.WriteLine(array[i, j]);
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма нечетных чисел массива = {ds.Calculate(array)}");
        }
    }
}
