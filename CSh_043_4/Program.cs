using System;

namespace CSh_043_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mark = Console.ReadLine();
            switch (mark)
            {
                case "1":
                    Console.WriteLine("Персонаж применяет аптечку");
                    break;
                case "2":
                    Console.WriteLine("ППерсонаж пьет зелье");
                    break;
                case "e":
                    Console.WriteLine("Персонаж открывает дверь");
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
