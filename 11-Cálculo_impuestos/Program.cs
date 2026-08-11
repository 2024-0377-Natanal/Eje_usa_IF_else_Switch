using System;

class Ejercicio11
{
    static void Main()
    {
        Console.Write("Ingresa tu salario mensual: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double impuesto;
        double porcentaje;

        if (salario < 10000)
        {
            porcentaje = 0;
        }
        else if (salario >= 10000 && salario <= 30000)
        {
            porcentaje = 0.10;
        }
        else
        {
            porcentaje = 0.20;
        }

        impuesto = salario * porcentaje;
        double salarioNeto = salario - impuesto;

        Console.WriteLine("Porcentaje de impuesto: " + (porcentaje * 100) + "%");
        Console.WriteLine("Monto del impuesto: " + impuesto);
        Console.WriteLine("Salario neto: " + salarioNeto);
    }
}
