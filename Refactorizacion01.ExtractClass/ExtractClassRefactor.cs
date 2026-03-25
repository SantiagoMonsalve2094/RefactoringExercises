using System;

public class Direccion
{
    public string Calle;
    public string Ciudad;

    public Direccion(string calle, string ciudad)
    {
        Calle = calle;
        Ciudad = ciudad;
    }

    public string ObtenerDireccion()
    {
        // ahora la direccion se maneja aparte
        return Calle + ", " + Ciudad;
    }
}

public class Persona
{
    public string Nombre;
    public Direccion Direccion;

    public Persona(string nombre, Direccion direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public void MostrarDatos()
    {
        // aca ya no guardo calle y ciudad por separado
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Direccion: " + Direccion.ObtenerDireccion());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // cree primero la direccion
        Direccion direccion = new Direccion("Cra 10", "Bucaramanga");

        // luego se la paso a la persona
        Persona persona = new Persona("Santiago", direccion);

        persona.MostrarDatos();
    }
}