using System;

class Ejercicio15
{
    static void Main()
    {
        Console.Write("Ingrese la primera longitud: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda longitud: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera longitud: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            Console.WriteLine("Las longitudes SI pueden formar un triangulo.");
        }
        else
        {
            Console.WriteLine("Las longitudes NO pueden formar un triangulo.");
        }
    }
}
