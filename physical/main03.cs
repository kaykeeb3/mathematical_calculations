
using System;

class GravitationalForceCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Força Gravitacional");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Fórmula: Força Gravitacional");
        Console.WriteLine("Força gravitacional (F) = (constante gravitacional (G) * massa1 * massa2) / distância^2");

        // Constante gravitacional em metros cúbicos por quilograma por segundo ao quadrado (m³/(kg·s²))
        double constanteGravitacional = 6.67430e-11;

        // Massa da Terra em quilogramas (kg)
        double massaTerra = 5.972e24;

        Console.Write("Digite a massa do objeto em quilogramas (kg): ");
        double massaObjeto = double.Parse(Console.ReadLine());

        Console.Write("Digite a distância do objeto ao centro da Terra em metros (m): ");
        double distancia = double.Parse(Console.ReadLine());

        double forcaGravitacional = (constanteGravitacional * massaTerra * massaObjeto) / Math.Pow(distancia, 2);

        Console.WriteLine($"A força gravitacional exercida pelo planeta é: {forcaGravitacional} newtons");

        Console.ReadLine();
    }
}
