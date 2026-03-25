using System;

public class ReporteVentas
{
    public void GenerarReporte()
    {
        Console.WriteLine("Cargando datos de ventas");
        Console.WriteLine("Procesando datos de ventas");
        Console.WriteLine("Mostrando reporte de ventas");
    }
}

public class ReporteCompras
{
    public void GenerarReporte()
    {
        Console.WriteLine("Cargando datos de compras");
        Console.WriteLine("Procesando datos de compras");
        Console.WriteLine("Mostrando reporte de compras");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ReporteVentas reporte1 = new ReporteVentas();
        reporte1.GenerarReporte();

        ReporteCompras reporte2 = new ReporteCompras();
        reporte2.GenerarReporte();
    }
}