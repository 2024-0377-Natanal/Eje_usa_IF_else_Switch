using System;

class Ejercicio01
{
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo.");
        }
        else
        {
            Console.WriteLine("El numero es cero.");
        }
    }
}
