using System;

class Ejercicio14
{
    static void Main()
    {
        Console.Write("Ingrese la calificacion numerica (0-100): ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        char letra;

        switch (calificacion / 10)
        {
            case 10:
            case 9:
                letra = 'A';
                break;
            case 8:
                letra = 'B';
                break;
            case 7:
                letra = 'C';
                break;
            case 6:
                letra = 'D';
                break;
            default:
                letra = 'F';
                break;
        }

        Console.WriteLine("La calificacion en letra es: " + letra);
    }
}
