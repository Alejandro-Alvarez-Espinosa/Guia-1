using System;

class Valores
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese los numeros a trabajar: ");
        int CantidadNum = Convert.ToInt32(Console.ReadLine());

        int[] Num = new int[CantidadNum];

        for (int i = 0; i < CantidadNum; i++)
        {
            Console.Write($"Ingrese el número {i + 1} : ");
            Num[i] = Convert.ToInt32(Console.ReadLine());
        }

        int Max = Num[0];

        for (int i = 1; i < CantidadNum; i++)
        {
            if (Num[i] > Max)
            {
                Max = Num[i];
            }
        }

        Console.WriteLine($"El valor más grande en el arreglo es:" + Max);
    }
}