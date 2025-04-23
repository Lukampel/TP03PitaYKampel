namespace TP03PitaYKampel.Models;

public class Artista
{
public int DNI { get; private set; }
public string Nombre { get; private set; }
public string Apellido { get; private set; }

public Artista (int dni, string nombre, string apellido) 
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.DNI=dni;
    }
}