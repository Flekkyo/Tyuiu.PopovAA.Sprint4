using Tyuiu.PopovAA.Sprint4.Task1.V19.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длинну массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введите значение {i}-ой переменной: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Значения массива: ");
            for (int i = 0; i < len; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(arr[i] + ".");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма его четных чисел = {ds.Calculate(arr)}");
        }
    }
}
