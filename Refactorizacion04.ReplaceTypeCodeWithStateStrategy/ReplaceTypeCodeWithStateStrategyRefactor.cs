using System;

public abstract class Envio
{
    public abstract double CalcularTotal(double precio);
}

public class EnvioNormal : Envio
{
    public override double CalcularTotal(double precio)
    {
        // este envio suma menos
        return precio + 5000;
    }
}

public class EnvioRapido : Envio
{
    public override double CalcularTotal(double precio)
    {
        // este cobra un poco mas
        return precio + 10000;
    }
}

public class Pedido
{
    public double Precio;
    public Envio Envio;

    public Pedido(double precio, Envio envio)
    {
        Precio = precio;
        Envio = envio;
    }

    public double CalcularTotal()
    {
        // ahora el tipo de envio ya no es texto
        return Envio.CalcularTotal(Precio);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // aca creo el envio aparte
        Envio envio = new EnvioRapido();

        Pedido pedido = new Pedido(20000, envio);
        Console.WriteLine("Total: " + pedido.CalcularTotal());
    }
}