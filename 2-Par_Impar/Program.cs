using System;

class Ejercicio02
{
    static void Main()
    {
        Console.Write("Ingresa un numero entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar.");
        }
    }
}
