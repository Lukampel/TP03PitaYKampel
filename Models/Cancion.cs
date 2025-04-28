namespace TP03PitaYKampel.Models;

public class Cancion
{

public string Nombre { get; private set; }
public string Duracion { get; private set; }

public Cancion (string nombre, string duracion) 
    {
        this.Nombre = nombre;
        this.Duracion = duracion;
        
    }
}