using Tyuiu.PopovAA.Sprint4.Task2.V14.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task2.V14
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
            Console.WriteLine("* Одномерные массивы. (генератор случайных чисел)                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Укажите длину массива: ");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 9);
                Console.WriteLine($"{i}-ый элемент равен {arr[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение нечетных элементов массива = {ds.Calculate(arr)}");
        }
    }
}
