using System;
class Ejercicio06
{
    static void Main()
    {
        Console.Write("Ingrese la calificacion (0-100): ");
        double calificacion = Convert.ToDouble(Console.ReadLine());

        if (calificacion >= 60)
        {
            Console.WriteLine("El estudiante aprobo.");
        }
        else
        {
            Console.WriteLine("El estudiante reprobo.");
        }
    }
}
