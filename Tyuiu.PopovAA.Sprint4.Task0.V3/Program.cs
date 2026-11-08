using Tyuiu.PopovAA.Sprint4.Task0.V3.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Значения массива: ");
            int[] arr = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 9)
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

            Console.WriteLine($"Произведение его нечетных чисел = {ds.GetMultOddArrEl(arr)}");
        }
    }
} 
