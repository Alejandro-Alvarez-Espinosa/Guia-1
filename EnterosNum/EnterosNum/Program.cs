using System;

    class NumEntero
    {
        static void Main(string[] args)
        {
            // -- Ingresar cinco números enteros --

            int[] num = new int[5];
            Console.WriteLine("Ingresa 5 números enteros:");
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            // -- Doble de cada número --

            Console.WriteLine("El doble de cada número ingresado es:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num[i] * 2);
            }
        }
    }
