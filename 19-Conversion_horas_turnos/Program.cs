using System;

class Ejercicio19
{
    static void Main()
    {
        Console.Write("Ingresa la hora (0-23): ");
        int hora = Convert.ToInt32(Console.ReadLine());

        string turno;

        switch (hora)
        {
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
                turno = "Mañana";
                break;
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
                turno = "Tarde";
                break;
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
                turno = "Noche";
                break;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                turno = "Madrugada";
                break;
            default:
                turno = "Hora invalida";
                break;
        }

        Console.WriteLine("El turno correspondiente es: " + turno);
    }
}
