using System;

class Ejercicio13
{
    static void Main()
    {
        Console.Write("Ingrese el año: ");
        int anio = Convert.ToInt32(Console.ReadLine());

        if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
        {
            Console.WriteLine("El año " + anio + " es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año " + anio + " no es bisiesto.");
        }
    }
}
