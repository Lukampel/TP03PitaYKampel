namespace TP03PitaYKampel.Models;

public class Cancion
{
public double DuracionMinutos { get; private set; }
public string Nombre { get; private set; }

public Cancion (double duracionMinutos, string nombre) 
    {
        this.Nombre = nombre;
        this.DuracionMinutos=duracionMinutos;
    }
}