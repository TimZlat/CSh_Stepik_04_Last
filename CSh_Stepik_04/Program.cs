using System;

namespace CSh_Stepik_04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = Convert.ToBoolean(Console.ReadLine());
            if (r)
            {
                Console.WriteLine("Попадание!");
            }
            else
            {
                Console.WriteLine("Промах.");
            }

            Console.ReadKey();
        }
    }
}
