using System;

namespace лб_8
{
    class Program
    {
        public delegate int Dog(int d, int o, int g);

        static void Main(string[] args)
        {
            Dog dog = delegate (int d, int o, int g)
            {
                return ((d + o + g) / 3);
            };
            try
            {
                Console.WriteLine("Введiть перше значення:");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть друге значення:");
                int o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть третє значення:");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Данi числа: {d} {o} { g}");
                Console.WriteLine($"Cередне арифметичне:{dog(d, o, g)}");
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
           Console.ReadKey();
        }
    }
}
