using Tyuiu.PopovAA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '10293847'. Преобразуйте ее в         *");
            Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "10293847";
            int[,] matrix = new int[4, 2];
            int index = 0;
            Console.WriteLine("Матрица размера 4x2 из заданной строки: ");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                    if (j == 0)
                    {
                        Console.Write("|" + matrix[i, j] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(matrix[i, j] + "|");
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество нечетных элементов этой матрицы = {ds.Calculate(4, 2, "10293847")} ");
        }
    }
}
