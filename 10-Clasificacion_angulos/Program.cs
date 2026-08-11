using System;

class Ejercicio10
{
    static void Main()
    {
        Console.Write("Ingrese el valor del angulo en grados: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        if (angulo < 90)
        {
            Console.WriteLine("El angulo es agudo.");
        }
        else if (angulo == 90)
        {
            Console.WriteLine("El angulo es recto.");
        }
        else if (angulo > 90 && angulo < 180)
        {
            Console.WriteLine("El angulo es obtuso.");
        }
        else if (angulo == 180)
        {
            Console.WriteLine("El angulo es llano.");
        }
        else
        {
            Console.WriteLine("El valor del angulo esta fuera de rango (0-180).");
        }
    }
}
