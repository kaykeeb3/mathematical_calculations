using System;

class PhysicsFormulaCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Fórmulas de Física");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("Fórmula: Energia Cinética");
        Console.WriteLine("Energia cinética (E) = (1/2) * massa (m) * velocidade ao quadrado (v^2)");

        Console.Write("Digite a massa do objeto em quilogramas (kg): ");
        double massa = double.Parse(Console.ReadLine());

        Console.Write("Digite a velocidade do objeto em metros por segundo (m/s): ");
        double velocidade = double.Parse(Console.ReadLine());

        double energiaCinetica = (1.0 / 2.0) * massa * Math.Pow(velocidade, 2);

        Console.WriteLine($"A energia cinética do objeto é: {energiaCinetica} joules");

        Console.ReadLine();
    }
}
