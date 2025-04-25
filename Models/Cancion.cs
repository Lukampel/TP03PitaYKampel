namespace TP03PitaYKampel.Models;

public class Cancion
{

public string Nombre { get; private set; }

public Cancion (string nombre) 
    {
        this.Nombre = nombre;
        
    }
}