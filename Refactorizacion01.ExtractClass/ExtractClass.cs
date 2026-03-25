using System;

public class Persona
{
    public string Nombre;
    public string Calle;
    public string Ciudad;

    public Persona(string nombre, string calle, string ciudad)
    {
        Nombre = nombre;
        Calle = calle;
        Ciudad = ciudad;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Direccion: " + Calle + ", " + Ciudad);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Persona persona = new Persona("Santiago", "Cra 10", "Bucaramanga");
        persona.MostrarDatos();
    }
}