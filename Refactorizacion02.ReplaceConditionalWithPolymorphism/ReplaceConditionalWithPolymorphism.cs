using System;

public class Empleado
{
    public string Nombre;
    public string Tipo;

    public Empleado(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public double CalcularPago()
    {
        if (Tipo == "TiempoCompleto")
        {
            return 3000;
        }
        else if (Tipo == "MedioTiempo")
        {
            return 1500;
        }
        else if (Tipo == "Practicante")
        {
            return 800;
        }
        else
        {
            return 0;
        }
    }

    public void MostrarPago()
    {
        Console.WriteLine(Nombre + " gana " + CalcularPago());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Empleado empleado = new Empleado("Santiago", "MedioTiempo");
        empleado.MostrarPago();
    }
}