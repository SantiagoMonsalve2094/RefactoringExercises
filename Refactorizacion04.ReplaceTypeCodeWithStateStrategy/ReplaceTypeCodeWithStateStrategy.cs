using System;

public class Pedido
{
    public double Precio;
    public string TipoEnvio;

    public Pedido(double precio, string tipoEnvio)
    {
        Precio = precio;
        TipoEnvio = tipoEnvio;
    }

    public double CalcularTotal()
    {
        if (TipoEnvio == "Normal")
        {
            return Precio + 5000;
        }
        else if (TipoEnvio == "Rapido")
        {
            return Precio + 10000;
        }
        else
        {
            return Precio;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pedido pedido = new Pedido(20000, "Rapido");
        Console.WriteLine("Total: " + pedido.CalcularTotal());
    }
}