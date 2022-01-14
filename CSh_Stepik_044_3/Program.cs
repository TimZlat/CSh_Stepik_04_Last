using System;

namespace CSh_Stepik_044_3
{
    class Program
    {
        //программа, которая запросит у пользователя значение, после чего выведет все числа до этого значения.
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());
            int count = 1;
            while (count<=n)
            {
                Console.WriteLine(count);
                count += 1;
            }
            Console.ReadKey();
        }
    }
}
