namespace TP03PitaYKampel.Models;

public class Productor
{
public int DNI { get; private set; }
public string Nombre { get; private set; }


public Productor (int dni, string nombre) 
    {
        this.DNI = dni;
        this.Nombre = nombre;

    }
}
