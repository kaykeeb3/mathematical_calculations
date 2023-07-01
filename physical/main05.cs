using System;

class GravityForceCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Força Gravitacional");
        Console.WriteLine("---------------------------------");

        // Massa do Sol em quilogramas (kg)
        double massaSol = 1.989e30;

        // Raio do Sol em metros (m)
        double raioSol = 6.9634e8;

        // Massa de Vênus em quilogramas (kg)
        double massaVenus = 4.867e24;

        // Raio de Vênus em metros (m)
        double raioVenus = 6.052e6;

        // Constante gravitacional em metros cúbicos por quilograma por segundo ao quadrado (m³/(kg·s²))
        double constanteGravitacional = 6.67430e-11;

        // Cálculo da força gravitacional no Sol
        double forcaGravitacionalSol = (constanteGravitacional * massaSol * massaSol) / Math.Pow(raioSol, 2);

        // Cálculo da força gravitacional em Vênus
        double forcaGravitacionalVenus = (constanteGravitacional * massaSol * massaVenus) / Math.Pow(raioVenus, 2);

        // Cálculo da diferença de força gravitacional entre Vênus e o Sol
        double diferencaForcaGravitacional = Math.Abs(forcaGravitacionalVenus - forcaGravitacionalSol);

        Console.WriteLine($"Força gravitacional no Sol: {forcaGravitacionalSol} newtons");
        Console.WriteLine($"Força gravitacional em Vênus: {forcaGravitacionalVenus} newtons");
        Console.WriteLine($"Diferença de força gravitacional: {diferencaForcaGravitacional} newtons");

        Console.ReadLine();
    }
}
