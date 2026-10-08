using System;
using dz_4.Enums;
using dz_4.Structs;

namespace dz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        //1

        static int[] RandomArray()
        {
            Random random = new Random();
            int[] num = new int[20];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(0, 100);
            }
            return num;
        }

        static void printArray(int[] num)
        {
            foreach (int number in num)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        static void SwapElement(int[] num, int num1, int num2)
        {
            int index1 = Array.IndexOf(num, num1);
            int index2 = Array.IndexOf(num, num2);

            int res = num[index1];
            num[index1] = num[index2];
            num[index2] = res;
        }
        static void Task1()
        {
            Console.WriteLine("#1");
            int[] num = RandomArray();
            Console.WriteLine("Массив:");
            printArray(num);
            Console.WriteLine("Введите первое число из массива:");
            int num1 = Input();

            Console.WriteLine("Введите второе число из массива:");
            int num2 = Input();

            SwapElement(num, num1, num2);
            Console.WriteLine("Массив после обмена:");
            printArray(num);

        }

        //2

        static int ProcessArray(ref int product, out double average, params int[] num)
        {
            int sum = 0;
            product = 1;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                product *= num[i];
            }
            average = (double)sum / num.Length;

            return sum;
        }
        static void Task2()
        {
            Console.WriteLine("#2");
            Console.WriteLine("Введите числа через пробел:");

            string[] digit = Console.ReadLine().Split(' ');
            int [] num = new int[digit.Length];

            for (int i = 0; i < digit.Length; i++)
            {
                num[i] = Convert.ToInt32(digit[i]);
            }
            int product = 0;
            double average = 0;

            int sum = ProcessArray(ref  product, out average, num);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");
        }

        //3

        static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка");
            Thread.Sleep(3000);
            Console.ResetColor();
        }

        static void Print(int digit)
        {
            string[] images =
            {
            " ### " +
            "\n#   #" +
            "\n#   #" +
            "\n#   #" +
            "\n ### ",

            "  #  " +
            "\n ##  " +
            "\n  #  " +
            "\n  #  " +
            "\n ### ",

            " ### " +
            "\n#   #" +
            "\n   # " +
            "\n  #  " +
            "\n#####",

            " ### " +
            "\n#   #" +
            "\n  ## " +
            "\n#   #" +
            "\n ### ",

            "#   #" +
            "\n#   #" +
            "\n#####" +
            "\n    #" +
            "\n    #",

            "#####" +
            "\n#    " +
            "\n#### " +
            "\n    #" +
            "\n#### ",

            " ### " +
            "\n#    " +
            "\n#### " +
            "\n#   #" +
            "\n ### ",

            "#####" +
            "\n    #" +
            "\n   # " +
            "\n  #  " +
            "\n #   ",

            " ### " +
            "\n#   #" +
            "\n ### " +
            "\n#   #" +
            "\n ### ",

            " ### " +
            "\n#   #" +
            "\n ####" +
            "\n    #" +
            "\n ### "
        };

            Console.WriteLine(images[digit]);
        }
        static void Task3()
        {
            Console.WriteLine("#3");
            Console.WriteLine("Введите число от 0 до 9");
            Console.WriteLine("Для выхода введие 'закрыть' или 'exit'");

            while (true)
            {
                Console.Write("Введите значение: ");
                string? input = Console.ReadLine();

                if (input == "exit" || input == "закрыть")
                    break;

                int num = 0;

                try
                {
                    num = Input();
                }
                catch
                {
                    throw new Exception("Вы вели не число");
                }


                if (num < 0 || num > 9)
                {
                    Error();
                    continue;
                }
                Print(num);
            }
        }

        //4
        static void Task4()
        {
            Console.WriteLine("#4");
            Grandpa[] grandpas =
            {
                new Grandpa("Артем", Grumpiness.Low, new string[] { "Гады!" }),
                new Grandpa("Михаил", Grumpiness.Medium, new string[] { "Дураки!", "Проститутки!" }),
                new Grandpa("Александр", Grumpiness.High, new string[] { "Черт!", "Гады!", "Проститутки!" }),
                new Grandpa("Игорь", Grumpiness.Medium, new string[] { "Бестолочи!", "Дураки!" }),
                new Grandpa("Федор", Grumpiness.Low, new string[] { "Гады!", "Черт!", "Дураки!" }),
            };

            string[] word = { "Гады!", "Черт!", "Проститутки!" };

            foreach (Grandpa grandpa in grandpas)
            {
                int bruise = grandpa.Bruise(word);
                Console.WriteLine($"{grandpa.Name}: фингалы: {bruise}");
            }
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
