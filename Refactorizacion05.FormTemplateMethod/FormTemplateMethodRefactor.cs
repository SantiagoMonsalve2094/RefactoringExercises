using System;

public abstract class Reporte
{
    public void GenerarReporte()
    {
        CargarDatos();
        ProcesarDatos();
        MostrarReporte();
    }

    public abstract void CargarDatos();
    public abstract void ProcesarDatos();
    public abstract void MostrarReporte();
}

public class ReporteVentas : Reporte
{
    public override void CargarDatos()
    {
        // este carga lo de ventas
        Console.WriteLine("Cargando datos de ventas");
    }

    public override void ProcesarDatos()
    {
        // este procesa ventas
        Console.WriteLine("Procesando datos de ventas");
    }

    public override void MostrarReporte()
    {
        // aca muestro el de ventas
        Console.WriteLine("Mostrando reporte de ventas");
    }
}

public class ReporteCompras : Reporte
{
    public override void CargarDatos()
    {
        // este carga lo de compras
        Console.WriteLine("Cargando datos de compras");
    }

    public override void ProcesarDatos()
    {
        // este procesa compras
        Console.WriteLine("Procesando datos de compras");
    }

    public override void MostrarReporte()
    {
        // aca muestro el de compras
        Console.WriteLine("Mostrando reporte de compras");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // los dos siguen el mismo orden
        Reporte reporte1 = new ReporteVentas();
        reporte1.GenerarReporte();

        Reporte reporte2 = new ReporteCompras();
        reporte2.GenerarReporte();
    }
}