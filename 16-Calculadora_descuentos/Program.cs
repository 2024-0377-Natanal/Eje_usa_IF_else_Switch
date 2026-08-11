using System;

class Ejercicio16
{
    static void Main()
    {
        Console.Write("Ingresa el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        double porcentajeDescuento;

        if (precio < 50)
        {
            porcentajeDescuento = 0;
        }
        else if (precio >= 50 && precio <= 100)
        {
            porcentajeDescuento = 0.05;
        }
        else
        {
            porcentajeDescuento = 0.10;
        }

        double descuento = precio * porcentajeDescuento;
        double precioFinal = precio - descuento;

        Console.WriteLine("Descuento aplicado: " + (porcentajeDescuento * 100) + "%");
        Console.WriteLine("Monto del descuento: " + descuento);
        Console.WriteLine("Precio final: " + precioFinal);
    }
}
