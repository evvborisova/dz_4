using System;

namespace tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Task51();
            Task52();
            Task53();
            Task54();
            Homework51();
            Homework52();
        }

        //5.1

        static int Max(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        static void Task51()
        {
            Console.WriteLine("#5.1");
            Console.WriteLine("Введите первое число:");
            int num1 = Input();

            Console.WriteLine("Введите второе число:");
            int num2 = Input();
            
            int result = Max(num1, num2);
            Console.WriteLine($"Наибольшее число: {result}");

        }
        
        //5.2

        static void Swap(ref int value1, ref int value2)
        {
            int res = value1;
            value1 = value2;
            value2 = res;
        }
        static void Task52()
        {
            Console.WriteLine("#5.2");
            Console.WriteLine("Введите первое число:");
            int value1 = Input();

            Console.WriteLine("Введите второе число:");
            int value2 = Input();

            Console.WriteLine($"До обмена: {value1}, {value2}");

            Swap(ref value1, ref value2);

            Console.WriteLine($"После обмена: {value1}, {value2}");
        }

        //5.3

        static bool Factorial(int fact, out int result1)
        {
            result1 = 1;

            try
            {
                checked
                {
                    for (int i = 2; i <= fact; i++)
                    {
                        result1 *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result1 = 0;
                return false;
            }
        }
        static void Task53()
        {
            Console.WriteLine("#5.3");
            Console.WriteLine("Введие число для вычисления факториала:");
            int fact = Input();
            
            if (Factorial(fact, out int result1))
            {
                Console.WriteLine($"Факториал: {result1}");
            }
            else
            {
                Console.WriteLine("Произошло переполнение");
            }
        }

        //5.4

        static long FactorilRecursive(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            return num * FactorilRecursive(num - 1);
        }
        static void Task54()
        {
            Console.WriteLine("#5.4");
            Console.WriteLine("Введите число для вычисления рекурсивного факториала:");
            int factRec = Input();
            long fact = FactorilRecursive(factRec);

            Console.WriteLine($"Факториал: {factRec}");
        }

        //5.1

        static int NOD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }
            return num1;
        }

        static int NOD(int num1, int num2, int num3)
        {
            return NOD(NOD(num1, num2), num3);
        }
        static void Homework51()
        {
            Console.WriteLine("#5.1");
            Console.WriteLine("Введите первое число:");
            int num1 = Input();

            Console.WriteLine("Введите второе число:");
            int num2 = Input();

            int resNOD1 = NOD( num1, num2 );
            Console.WriteLine($"НОД двух чисел: {resNOD1}");

            Console.WriteLine("Введите третье число:");
            int num3 = Input();

            int resNOD2 = NOD(num1, num2, num3);
            Console.WriteLine($"НОД трех чисел: {resNOD2}");
        }

        //5.2

        static long Fibonachi(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n ==1 || n == 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Homework52()
        {
            Console.WriteLine("#5.2");
            Console.WriteLine("Введите n:");
            int n = Input();

            long resN = Fibonachi(n);
            Console.WriteLine($"Число Фибоначи: {resN}");
        }

        static int Input()
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                return n;
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            return 0;
        }
    }
}
