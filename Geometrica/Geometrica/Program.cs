using System;

class Geometria
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la base del triangulo: ");
        double Base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo: ");
        double Altura = Convert.ToDouble(Console.ReadLine());

        double Area = (Base * Altura) / 2;

        Console.WriteLine($"El area del triangulo es: " + Area);
    }
}
