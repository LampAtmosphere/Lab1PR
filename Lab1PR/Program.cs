using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат: " + CalcSum(n, x));
    }

    static double CalcSum(int n, int x)
    {
        double sum = 0;
        for (int nn = 0; nn <= n; nn++)
        {
            sum += 1 / ((2 * nn + 1) * Math.Pow(x, 2 * nn + 1));
        }
        return sum;
    }
}