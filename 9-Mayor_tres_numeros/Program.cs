using System;

class Ejercicio09
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer numero: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double mayor;

        if (num1 >= num2 && num1 >= num3)
        {
            mayor = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            mayor = num2;
        }
        else
        {
            mayor = num3;
        }

        Console.WriteLine("El mayor de los tres numeros es: " + mayor);
    }
}
