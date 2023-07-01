using System;

class Program
{
    static void Main()
    {
        double distanciaTerraSol = 149.6 * Math.Pow(10, 6); // Distância média da Terra ao Sol em quilômetros
        double velocidadeTerra = 29.78; // Velocidade média orbital da Terra em quilômetros por segundo

        double distanciaVoltaCompleta = 2 * Math.PI * distanciaTerraSol;
        double tempoVoltaCompleta = distanciaVoltaCompleta / (velocidadeTerra * 60 * 60 * 24 * 365.25);

        double tempoDecada = tempoVoltaCompleta * 10;

        Console.WriteLine("Tempo para uma volta completa ao redor do Sol: " + tempoVoltaCompleta + " anos");
        Console.WriteLine("Tempo para uma década de voltas completas ao redor do Sol: " + tempoDecada + " anos");
    }
}
