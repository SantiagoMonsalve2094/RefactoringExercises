using System;

public abstract class Empleado
{
    public string Nombre;

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public abstract double CalcularPago();

    public void MostrarPago()
    {
        // cada tipo de empleado ya calcula su pago aparte
        Console.WriteLine(Nombre + " gana " + CalcularPago());
    }
}

public class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre) : base(nombre)
    {
    }

    public override double CalcularPago()
    {
        // este es el pago fijo de tiempo completo
        return 3000;
    }
}

public class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre) : base(nombre)
    {
    }

    public override double CalcularPago()
    {
        // aqui va el pago de medio tiempo
        return 1500;
    }
}

public class EmpleadoPracticante : Empleado
{
    public EmpleadoPracticante(string nombre) : base(nombre)
    {
    }

    public override double CalcularPago()
    {
        // este seria el pago del practicante
        return 800;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // ahora ya no uso if ni else para saber el pago
        Empleado empleado = new EmpleadoMedioTiempo("Santiago");
        empleado.MostrarPago();
    }
}