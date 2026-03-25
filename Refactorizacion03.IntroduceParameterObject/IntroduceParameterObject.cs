using System;

public class Reporte
{
    public void GenerarReporte(string nombreCliente, string ciudad, string fechaInicio, string fechaFin)
    {
        Console.WriteLine("Cliente: " + nombreCliente);
        Console.WriteLine("Ciudad: " + ciudad);
        Console.WriteLine("Fecha inicio: " + fechaInicio);
        Console.WriteLine("Fecha fin: " + fechaFin);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Reporte reporte = new Reporte();
        reporte.GenerarReporte("Santiago", "Bucaramanga", "01/03/2026", "10/03/2026");
    }
}