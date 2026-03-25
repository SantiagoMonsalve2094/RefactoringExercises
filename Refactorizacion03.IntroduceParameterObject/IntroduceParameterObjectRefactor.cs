using System;

public class DatosReporte
{
    public string NombreCliente;
    public string Ciudad;
    public string FechaInicio;
    public string FechaFin;

    public DatosReporte(string nombreCliente, string ciudad, string fechaInicio, string fechaFin)
    {
        NombreCliente = nombreCliente;
        Ciudad = ciudad;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
    }
}

public class Reporte
{
    public void GenerarReporte(DatosReporte datos)
    {
        // aca ya mando un solo objeto y no muchos parametros
        Console.WriteLine("Cliente: " + datos.NombreCliente);
        Console.WriteLine("Ciudad: " + datos.Ciudad);
        Console.WriteLine("Fecha inicio: " + datos.FechaInicio);
        Console.WriteLine("Fecha fin: " + datos.FechaFin);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // hice una clase aparte para guardar esos datos
        DatosReporte datos = new DatosReporte("Santiago", "Bucaramanga", "01/03/2026", "10/03/2026");

        Reporte reporte = new Reporte();
        reporte.GenerarReporte(datos);
    }
}