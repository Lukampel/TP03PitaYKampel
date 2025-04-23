namespace TP03PitaYKampel.Models;

public class Disco
{
public int ID{ get; private set; }

public string nombreAlbum{ get; private set; }
public Artista artista { get; private set; }
public List<Cancion> listaCanciones { get; private set; }
public Productor productor { get; private set; }
public string foto { get; private set; }
public string generoMusical { get; private set; }

public DateTime FechaCreacion { get; private set; }
public Disco (int id, Artista Artista, Productor Productor, string Foto, string GeneroMusical, string NombreAlbum, DateTime fechaCreacion) 
    {
        this.ID=id;
        this.artista=Artista;
        this.productor=Productor;
        this.foto=Foto;
        this.generoMusical=GeneroMusical;
        this.nombreAlbum=NombreAlbum;
        this.FechaCreacion = fechaCreacion;
         listaCanciones=new List<Cancion>();
    }


}

