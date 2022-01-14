using System;

namespace CSh_Stepik_046_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -100; i < 100; i++)
            {
                Console.WriteLine("Для остановки введите 'exit':");
                string str = Console.ReadLine();
                if (str == "exit")
                { break; }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
