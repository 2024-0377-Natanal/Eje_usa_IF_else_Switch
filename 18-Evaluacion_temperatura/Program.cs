using System;

class Ejercicio18
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura < 0)
        {
            Console.WriteLine("\n'Hace mucho frío'");
        }
        else if (temperatura >= 0 && temperatura <= 20)
        {
            Console.WriteLine("\n'Clima fresco'");
        }
        else if (temperatura >= 21 && temperatura <= 30)
        {
            Console.WriteLine("\n'Clima agradable'");
        }
        else
        {
            Console.WriteLine("\n'Hace mucho calor'");
        }
    }
}
