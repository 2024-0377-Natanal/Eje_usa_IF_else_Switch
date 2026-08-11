using System;

class Ejercicio04
{
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 5 == 0)
        {
            Console.WriteLine("El numero es un multiplo de 5.");
        }
        else
        {
            Console.WriteLine("El numero NO es un multiplo de 5.");
        }
    }
}
