using System;

class Ejercicio17
{
    static void Main()
    {
        Console.Write("Ingrese la primera longitud: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda longitud: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera longitud: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es equilatero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triangulo es isosceles.");
        }
        else
        {
            Console.WriteLine("El triangulo es escaleno.");
        }
    }
}
