using System;

class VenusMassCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Massa em Vênus");
        Console.WriteLine("-----------------------------");

        // Massa da Terra em quilogramas (kg)
        double massaTerra = 5.972e24;

        // Raio da Terra em metros (m)
        double raioTerra = 6.371e6;

        // Aceleração da gravidade na Terra em metros por segundo ao quadrado (m/s²)
        double aceleracaoGravidadeTerra = 9.81;

        // Constante gravitacional em metros cúbicos por quilograma por segundo ao quadrado (m³/(kg·s²))
        double constanteGravitacional = 6.67430e-11;

        // Raio de Vênus em metros (m)
        double raioVenus = 6.052e6;

        Console.Write("Digite o peso do corpo na Terra em newtons (N): ");
        double pesoTerra = double.Parse(Console.ReadLine());

        // Cálculo da aceleração da gravidade em Vênus
        double aceleracaoGravidadeVenus = (constanteGravitacional * massaTerra) / Math.Pow(raioVenus, 2);

        // Cálculo da massa do corpo em Vênus
        double massaVenus = pesoTerra / aceleracaoGravidadeVenus;

        Console.WriteLine($"A massa do corpo em Vênus é: {massaVenus} quilogramas");

        Console.ReadLine();
    }
}
