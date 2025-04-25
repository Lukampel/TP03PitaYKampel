namespace TP03PitaYKampel.Models;

public class Artista
{
public int DNI { get; private set; }
public string Nombre { get; private set; }

public Artista (int dni, string nombre) 
    {
        this.Nombre = nombre;
        this.DNI=dni;
    }
}