using System;

namespace C_Sh_Stepik05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа "Записная книжка" 
            //Stepik C# курс для начинающих 
            //задание 51
            Console.Write("Введите имя:");
            string n = Console.ReadLine();
            Console.WriteLine("Имя ученика:"+n);
            Console.Write("Введите возраст:");
            int voz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возраст ученика:"+voz);
            Console.Write("Введите балл по русскому языку:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите балл по по математике:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите балл по по информатике:");
            int b3 = Convert.ToInt32(Console.ReadLine());
            double sr = (b1 + b2 + b3) / 3;
            Console.WriteLine("Средний балл ученика:" + Convert.ToString(sr));
            Console.ReadKey();
        }
    }
}
