using System;

class Ejercicio07
{
    static void Main()
    {
        Console.Write("Ingrese un numero del 1 al 7: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("\n'Lunes'");
                break;
            case 2:
                Console.WriteLine("\n'Martes'");
                break;
            case 3:
                Console.WriteLine("\n'Miercoles'");
                break;
            case 4:
                Console.WriteLine("\n'Jueves'");
                break;
            case 5:
                Console.WriteLine("\n'Viernes'");
                break;
            case 6:
                Console.WriteLine("\n'Sabado'");
                break;
            case 7:
                Console.WriteLine("\n'Domingo'");
                break;
            default:
                Console.WriteLine("Numero invalido, debe estar entre 1 y 7.");
                break;
        }
    }
}
