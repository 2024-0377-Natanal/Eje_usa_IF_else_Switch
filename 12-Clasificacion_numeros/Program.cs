using System;

class Ejercicio12
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer numero: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("Hay al menos un cero entre los numeros.");
        }
        else if (num1 > 0 && num2 > 0 && num3 > 0)
        {
            Console.WriteLine("Todos los numeros son positivos.");
        }
        else if (num1 < 0 && num2 < 0 && num3 < 0)
        {
            Console.WriteLine("Todos los numeros son negativos.");
        }
        else
        {
            Console.WriteLine("Los numeros son mixtos.");
        }
    }
}
