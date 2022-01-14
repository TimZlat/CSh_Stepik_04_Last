using System;

namespace CSh_042_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean virus, HighTemperature, IsCooling; 
            virus = Convert.ToBoolean(Console.ReadLine());
            HighTemperature = Convert.ToBoolean(Console.ReadLine());
            IsCooling= Convert.ToBoolean(Console.ReadLine());
            if (virus && HighTemperature&&!IsCooling)
            { Console.WriteLine("Угроза повреждения системы!"); 
            }
            else
            {
                Console.WriteLine("Обнаружены незначительные угрозы.");
            }
            Console.ReadKey();
        }
    }
}
