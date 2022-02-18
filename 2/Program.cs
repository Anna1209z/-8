using System;

namespace _2
{
    class Program
    {
        public delegate int Deleg1();
        public delegate int Deleg2(Deleg1[] Array);

        public static Random random = new Random();
        public static int RandomNums() => random.Next(100);
        static void Main(string[] args)
        {
            Deleg1[] deleg1s = new Deleg1[5];
            int[] arr = new int[deleg1s.Length];

            for (int i = 0; i < deleg1s.Length; i++)
            {
                 
                deleg1s[i] = RandomNums;
            }
            Console.WriteLine("Виведення масиву");
            Console.WriteLine();
            for (int i = 0; i < deleg1s.Length; i++)
            {
                arr[i] = deleg1s[i]();
                Console.WriteLine(arr[i]);
            }
            Deleg2 deleg2 = delegate (Deleg1[] massive)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                   
                    sum = sum + arr[i];
                }
                Console.WriteLine($"Сумма = {sum}");

                
                return sum / (massive.Length);
            };
            Console.WriteLine();
            Console.WriteLine($"Среднє арифметичне значення чисел масива = {deleg2(deleg1s)}");

            Console.ReadKey();
        }
    }
}
