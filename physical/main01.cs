using System;

class SolarTemperatureCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Temperatura Solar Anual");
        Console.WriteLine("--------------------------------------");

        Console.Write("Digite a temperatura média em Kelvin: ");
        double temperaturaMedia = double.Parse(Console.ReadLine());

        Console.Write("Digite a distância média em unidades astronômicas (UA): ");
        double distanciaMedia = double.Parse(Console.ReadLine());

        Console.Write("Digite a radiação solar média em Watts por metro quadrado (W/m²): ");
        double radiacaoSolarMedia = double.Parse(Console.ReadLine());

        // Fator de correção considerando a variação da distância ao quadrado
        double fatorCorrecao = Math.Pow(1 / distanciaMedia, 2);

        // Cálculo da temperatura média anual
        double temperaturaAnual = temperaturaMedia * Math.Sqrt(radiacaoSolarMedia) * Math.Sqrt(fatorCorrecao);

        Console.WriteLine($"A temperatura média anual é: {temperaturaAnual} Kelvin");

        Console.ReadLine();
    }
}
