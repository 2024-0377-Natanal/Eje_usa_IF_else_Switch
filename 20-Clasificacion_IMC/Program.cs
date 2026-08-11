using System;

class Ejercicio20
{
    static void Main()
    {
        Console.Write("Ingrese su peso en (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura en (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        string clasificacion;

        if (imc < 18.5)
        {
            clasificacion = "Bajo peso";
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            clasificacion = "Normal";
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            clasificacion = "Sobrepeso";
        }
        else
        {
            clasificacion = "Obesidad";
        }

        Console.WriteLine("Tu IMC es: " + Math.Round(imc, 2));
        Console.WriteLine("Clasificación: " + clasificacion);
    }
}
