using Tyuiu.PopovAA.Sprint4.Task6.V8.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Класс Array                                                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 4 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            Console.WriteLine("Входящий массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.WriteLine(array[i] + ".");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы массива, длина которых больше 4 символов: ");
            string[] otv = ds.Calculate(array);
            for (int i = 0; i < otv.Length; i++)
            {
                if (i != otv.Length - 1)
                {
                    Console.Write(otv[i] + ", ");
                }
                else
                {
                    Console.WriteLine(otv[i] + ".");
                }
            }
        }
    }
}
