using System;

class BhaskaraCalculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Bhaskara");
        Console.WriteLine("-----------------------");

        Console.Write("Digite o valor de a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("A equação possui uma raiz real:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("A equação possui duas raízes reais:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }

        Console.ReadLine();
    }
}
