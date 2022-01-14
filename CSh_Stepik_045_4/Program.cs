using System;

namespace CSh_Stepik_045_4
{
    /// <summary>
    /// Использование цикла for.вывод фрагмента таблицы умножения
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= n1; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n2, 2, n2 * 2);
                n2++;
            }
            
            Console.ReadKey();
        }
    }
}
