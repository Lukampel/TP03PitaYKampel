namespace TP03PitaYKampel.Models;

public class Discos
{
static public Dictionary<int, Disco> discos { get; private set; }
public static void InicializarDiscos()
    {
        discos = new Dictionary<int, Disco>();
        Artista artista1 = new Artista(1, "Kaytranada");
        Productor productor1 = new Productor(01, "Kaytranada");
        Disco disco1 = new Disco(001 ,artista1, productor1, "/Images/timeless.jpg", "Electrónica", "Timeless", new DateTime(2024, 6, 7));

        Artista artista2 = new Artista(2, "Kanye West");
        Productor productor2 = new Productor(02, "Mike Dean");
        Disco disco2 = new Disco(002 ,artista2, productor2, "/Images/MBDTF.jpg", "Hip Hop", "My Beautiful Dark Twisted Fantasy", new DateTime(2010, 11, 22));

        Artista artista3 = new Artista(3, "T.I");
        Productor productor3 = new Productor(03, "Avedon");
        Disco disco3 = new Disco(003 ,artista3, productor3, "/Images/Dimetrap.jpg", "Hip Hop", "Dime Trap", new DateTime(2018, 10, 5));

        Artista artista4 = new Artista(4, "JID");
        Productor productor4 = new Productor(04, "J. Cole");
        Disco disco4 = new Disco(004 ,artista4, productor4, "/Images/TNS.jpg", "Hip Hop", "The Never Story", new DateTime(2017, 3, 10));

        Artista artista5 = new Artista(5, "Bad Bunny");
        Productor productor5 = new Productor(05, "Tainy");
        Disco disco5 = new Disco(005 ,artista5, productor5, "/Images/YHLQMDLG.jpg", "Reggaetón", "YHLQMDLG", new DateTime(2020, 2, 29));

        
        Artista artista6 = new Artista(6, "J Balvin");
        Productor productor6 = new Productor(06, "Sky Rompiendo");
        Disco disco6 = new Disco(006 ,artista6, productor6, "/Images/Colores.jpg", "Reggaetón", "Colores", new DateTime(2020, 3, 19));

        Artista artista7 = new Artista(7, "Karol G");
        Productor productor7 = new Productor(07, "Ovy On The Drums");
        Disco disco7 = new Disco(007 ,artista7, productor7, "/Images/Ocean.jpg", "Reggaetón", "Ocean", new DateTime(2019, 5, 3));

        Artista artista8 = new Artista(8, "Anuel AA");
        Productor productor8 = new Productor(08, "Chris Jedi");
        Disco disco8 = new Disco(008 ,artista8, productor8, "/Images/RHLM.jpg", "Latin Trap", "Real Hasta la Muerte", new DateTime(2018, 7, 17));

         Artista artista9 = new Artista(9, "YSY A");
        Productor productor9 = new Productor(09, "Asan");
        Disco disco9 = new Disco(009,artista9, productor9, "/Images/HechoAmano.jpg", "Trap", "Hecho a Mano", new DateTime(2019, 11, 11));

        Artista artista10 = new Artista(10, "Travis Scott");
        Productor productor10 = new Productor(010, "Metro Boomin");
        Disco disco10 = new Disco(0010,artista10, productor10, "/Images/Rodeo.jpg", "Trap", "Rodeo", new DateTime(2015, 9, 4));
        
        discos.Add(001,disco1);
        discos.Add(002,disco2);
        discos.Add(003,disco3);
        discos.Add(004,disco4);
        discos.Add(005,disco5);
        discos.Add(006,disco6);
        discos.Add(007,disco7);
        discos.Add(008,disco8);
        discos.Add(009,disco9);
        discos.Add(0010,disco10);
      
    }
    static public Dictionary<int,Disco> Devolverdiscos(){
        return discos;
    }
}