using Tyuiu.PopovAA.Sprint4.Task5.V7.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -7 до 7.               *");
            Console.WriteLine("* Найти количество отрицательных элементов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-7, 8);
                }
            }

            Console.WriteLine("Массив из случайных чисел: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < 4 & matrix[i, j] >= 0)
                    {
                        Console.Write(" " + matrix[i, j] + ", ");
                    }
                    else if (j < 4)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    else if (j == 4 & matrix[i, j] >= 0)
                    {
                        Console.WriteLine(" " + matrix[i, j]);
                    }
                    else
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество отрицательных чисел в сегнерированном масииве = {ds.Calculate(matrix)}");
        }
    }
} 
