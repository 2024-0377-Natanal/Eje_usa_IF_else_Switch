using System;

class Ejercicio08
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("El mayor es: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("El mayor es: " + num2);
        }
        else
        {
            Console.WriteLine("Ambos numeros son iguales.");
        }
    }
}
