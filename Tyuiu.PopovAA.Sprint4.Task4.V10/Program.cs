using Tyuiu.PopovAA.Sprint4.Task4.V10.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7.              *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк массива: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество стобцов массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[lines, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент с индексом {i}, {j}. Элемент в диапазоне от 1 до 7: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Готовая матрица: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < array.GetLength(1) - 1)
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

            Console.WriteLine("Матрица после преобразований: ");

            int[,] mtrx = (ds.Calculate(array));

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (j < array.GetLength(1) - 1)
                    {
                        Console.Write(array[i, j] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(array[i, j]);
                    }
                }
            }
        }
    }
}
