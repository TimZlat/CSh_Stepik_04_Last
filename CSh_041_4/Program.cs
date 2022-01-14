using System;
/// <summary>
/// программа, которая проверит на четность число вводимое пользователем.
/// </summary>
namespace CSh_041_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 %2 ==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            Console.ReadKey();
        }
    }
}
