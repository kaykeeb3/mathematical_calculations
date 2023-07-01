using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculating PI...");

        // Tempo de execução em milissegundos
        int executionTime = 100000;

        // Número total de pontos
        int totalPoints = 0;

        // Número de pontos dentro do círculo
        int pointsInsideCircle = 0;

        // Semente para o gerador de números aleatórios
        Random random = new Random();

        // Tempo inicial
        DateTime startTime = DateTime.Now;

        // Loop até que o tempo de execução expire
        while ((DateTime.Now - startTime).TotalMilliseconds < executionTime)
        {
            // Gera um ponto aleatório no quadrado unitário
            double x = random.NextDouble();
            double y = random.NextDouble();

            // Calcula a distância em relação ao centro
            double distance = Math.Sqrt(x * x + y * y);

            // Verifica se o ponto está dentro do círculo unitário
            if (distance < 1)
            {
                pointsInsideCircle++;
            }

            totalPoints++;
        }

        // Calcula o valor de PI
        double pi = 4.0 * pointsInsideCircle / totalPoints;

        Console.WriteLine($"PI = {pi}");
    }
}
