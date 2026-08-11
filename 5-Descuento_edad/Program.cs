using System;

class Ejercicio05
{
    static void Main()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad > 60)
        {
            Console.WriteLine("Aplicas para el descuento del 50%.");
        }
        else
        {
            Console.WriteLine("No aplicas para el descuento.");
        }
    }
}
