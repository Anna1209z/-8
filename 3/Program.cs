using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть перше число:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введiть номер дiї:\n 1)+ \n 2)- \n 3)* \n 4):");
                    int oper = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть друге значення:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Caculator caculator = new Caculator(a, b, oper);
                    caculator.AllOperations();

                }
                catch (Exception a)
                {

                    Console.WriteLine(a.Message);
                }
            }
            Console.ReadKey();
        }

    } 
    class Caculator
    {
        public double a, b;
        public int oper;
        delegate double Del(double a, double b);
        public Caculator(double a, double b, int oper)
        {
            this.a = a;
            this.b = b;
            this.oper = oper;
        }
        Del Add = (double a, double b) => { return a + b; };
        Del Sub = (double a, double b) => { return a - b; };
        Del Div = (double a, double b) => { return a / b; };
        Del Mul = (double a, double b) => { return a * b; };

        public void AllOperations()
        {
            if (oper == 1)
            {
                Console.WriteLine($"{a} + {b} ={Add(a,b)}");
            }
            else if (oper == 2)
            {
                Console.WriteLine($"{a} - {b} = {Sub(a,b)}");
            }
            else if (oper == 3)
            {
                Console.WriteLine($"{a} * {b} = {Mul(a,b)}");
            }
            else if (oper == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Дiлення на 0 неможливе!");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {Div(a, b)}");
                }
            }
            else
            {
                Console.WriteLine("Оберiть номер дiї iз вище зазначених: 1 або 2 або 3 або 4");
            }

        }
     }
 }
