using System;

class Program
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMinutes(1);
        int iterations = 0;
        double pi = 0;

        while (DateTime.Now < endTime)
        {
            pi += (iterations % 2 == 0 ? 1.0 : -1.0) / (2 * iterations + 1);
            iterations++;
        }

        pi *= 4;
        Console.WriteLine($"Valor de PI: {pi}");
    }
}
