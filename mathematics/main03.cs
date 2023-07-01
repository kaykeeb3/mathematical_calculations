using System;

class AlgebraicExpressionCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Expressões Algébricas");
        Console.WriteLine("------------------------------------");

        Console.Write("Digite o valor de x: ");
        double x = double.Parse(Console.ReadLine());

        // Exemplo de expressão algébrica: f(x) = 2x^2 + 3x - 5
        double resultado = 2 * Math.Pow(x, 2) + 3 * x - 5;

        Console.WriteLine($"O valor da expressão para x = {x} é: {resultado}");

        Console.ReadLine();
    }
}
