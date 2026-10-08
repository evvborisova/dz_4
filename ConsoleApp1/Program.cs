using System;

class Program
{
    static void Main()
    {
        int length = 10;
        Random random = new Random();
        int numbers = new int [length];

        for (int i = 0; i < length; i++)
        {
            numbers[i] = random.Next(100);
        }

        Console.WriteLine("Случайные числа: " + string.Join(", ", numbers));
    }
}

