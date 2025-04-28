namespace TP03PitaYKampel.Models;

public class Discos
{
    static public Dictionary<int, Disco> discos { get; private set; }
    public static void InicializarDiscos()
    {


        discos = new Dictionary<int, Disco>();
        Artista artista1 = new Artista(1, "Kaytranada");
        Productor productor1 = new Productor(01, "Kaytranada");
        Disco disco1 = new Disco(001, artista1, productor1, "/Images/timeless.jpg", "Electrónica", "Timeless", new DateTime(2024, 6, 7));
        agregarDisco1(disco1);
       
        Artista artista2 = new Artista(2, "Kanye West");
        Productor productor2 = new Productor(02, "Mike Dean");
        Disco disco2 = new Disco(002, artista2, productor2, "/Images/MBDTF.jpg", "Hip Hop", "My Beautiful Dark Twisted Fantasy", new DateTime(2010, 11, 22));
         agregarDisco2(disco2);




        Artista artista3 = new Artista(3, "T.I");
        Productor productor3 = new Productor(03, "Avedon");
        Disco disco3 = new Disco(003, artista3, productor3, "/Images/Dimetrap.jpg", "Hip Hop", "Dime Trap", new DateTime(2018, 10, 5));
         agregarDisco3(disco3);

        Artista artista4 = new Artista(4, "JID");
        Productor productor4 = new Productor(04, "J. Cole");
        Disco disco4 = new Disco(004, artista4, productor4, "/Images/TNS.jpg", "Hip Hop", "The Never Story", new DateTime(2017, 3, 10));
         agregarDisco4(disco4);

        Artista artista5 = new Artista(5, "Bad Bunny");
        Productor productor5 = new Productor(05, "Tainy");
        Disco disco5 = new Disco(005, artista5, productor5, "/Images/YHLQMDLG.jpg", "Reggaetón", "YHLQMDLG", new DateTime(2020, 2, 29));
         agregarDisco5(disco5);

        Artista artista6 = new Artista(6, "J Balvin");
        Productor productor6 = new Productor(06, "Sky Rompiendo");
        Disco disco6 = new Disco(006, artista6, productor6, "/Images/Colores.jpg", "Reggaetón", "Colores", new DateTime(2020, 3, 19));
         agregarDisco6(disco6);
        Artista artista7 = new Artista(7, "Karol G");
        Productor productor7 = new Productor(07, "Ovy On The Drums");
        Disco disco7 = new Disco(007, artista7, productor7, "/Images/Ocean.jpg", "Reggaetón", "Ocean", new DateTime(2019, 5, 3));
         agregarDisco7(disco7);
        Artista artista8 = new Artista(8, "Anuel AA");
        Productor productor8 = new Productor(08, "Chris Jedi");
        Disco disco8 = new Disco(008, artista8, productor8, "/Images/RHLM.jpg", "Latin Trap", "Real Hasta la Muerte", new DateTime(2018, 7, 17));
         agregarDisco8(disco8);
        Artista artista9 = new Artista(9, "YSY A");
        Productor productor9 = new Productor(09, "Asan");
        Disco disco9 = new Disco(009, artista9, productor9, "/Images/HechoAmano.jpg", "Trap", "Hecho a Mano", new DateTime(2019, 11, 11));
         agregarDisco9(disco9);
        Artista artista10 = new Artista(10, "Travis Scott");
        Productor productor10 = new Productor(010, "Metro Boomin");
        Disco disco10 = new Disco(0010, artista10, productor10, "/Images/Rodeo.jpg", "Trap", "Rodeo", new DateTime(2015, 9, 4));
         agregarDisco10(disco10);

        discos.Add(001, disco1);
        discos.Add(002, disco2);
        discos.Add(003, disco3);
        discos.Add(004, disco4);
        discos.Add(005, disco5);
        discos.Add(006, disco6);
        discos.Add(007, disco7);
        discos.Add(008, disco8);
        discos.Add(009, disco9);
        discos.Add(0010, disco10);

    }
    static public Dictionary<int, Disco> Devolverdiscos()
    {
        return discos;
    }
    static public Cancion devolverCancion(string s, string a)
    {
        Cancion cancion =new Cancion(s,a);
        return cancion;
    }
    static public void  agregarDisco1(Disco disco1){
 Cancion cancion1 = devolverCancion("Pressure", "1:58");
        Cancion cancion2 = devolverCancion("Spit It Out (feat. Rochelle Jordan)", "3:38");
        Cancion cancion3 = devolverCancion("Call U Up (feat. Lou Phelps)", "2:58");
        Cancion cancion4 = devolverCancion("Weird (feat. Durand Bernarr)", "3:27");
        Cancion cancion5 = devolverCancion("Dance Dance Dance Dance", "1:42");
        Cancion cancion6 = devolverCancion("Feel A Way (feat. Don Toliver)", "3:16");
        Cancion cancion7 =devolverCancion("Still", "2:14");
        Cancion cancion8 = devolverCancion("Video (feat. Ravyn Lenae)", "3:12");
        Cancion cancion9 = devolverCancion("Seemingly", "3:17");
        Cancion cancion10 = devolverCancion("Drip Sweat (feat. Channel Tres)", "2:27");
        Cancion cancion11 =devolverCancion("Hold On (feat. Dawn Richard)", "3:16");
        Cancion cancion12 =devolverCancion("Please Babe", "2:46");
        Cancion cancion13 = devolverCancion("Stepped On", "3:01");
        Cancion cancion14 = devolverCancion("More Than A Little Bit (feat. Tinashe)", "2:54");
        Cancion cancion15 = devolverCancion("Do 2 Me (feat. Anderson .Paak & SiR)", "3:50");
        Cancion cancion16 = devolverCancion("Witchy (feat. Childish Gambino)", "3:47");
        Cancion cancion17 = devolverCancion("Lover/Friend (feat. Rochelle Jordan)", "4:19");
        Cancion cancion18 = devolverCancion("Wasted Words (feat. Thundercat)", "1:27");
        Cancion cancion19 = devolverCancion("Snap My Finger (feat. PinkPantheress)", "1:27");
        Cancion cancion20 = devolverCancion("Stuntin (feat. Channel Tres)", "3:02");
        Cancion cancion21 = devolverCancion("Out Of Luck (feat. Mariah the Scientist)", "2:58");
        disco1.agregarCancionesAlaLista(cancion1);
        disco1.agregarCancionesAlaLista(cancion2);
        disco1.agregarCancionesAlaLista(cancion3);
        disco1.agregarCancionesAlaLista(cancion4);
        disco1.agregarCancionesAlaLista(cancion5);
        disco1.agregarCancionesAlaLista(cancion6);
        disco1.agregarCancionesAlaLista(cancion7);
        disco1.agregarCancionesAlaLista(cancion8);
        disco1.agregarCancionesAlaLista(cancion9);
        disco1.agregarCancionesAlaLista(cancion10);
        disco1.agregarCancionesAlaLista(cancion11);
        disco1.agregarCancionesAlaLista(cancion12);
        disco1.agregarCancionesAlaLista(cancion13);
        disco1.agregarCancionesAlaLista(cancion14);
        disco1.agregarCancionesAlaLista(cancion15);
        disco1.agregarCancionesAlaLista(cancion16);
        disco1.agregarCancionesAlaLista(cancion17);
        disco1.agregarCancionesAlaLista(cancion18);
        disco1.agregarCancionesAlaLista(cancion19);
        disco1.agregarCancionesAlaLista(cancion20);
        disco1.agregarCancionesAlaLista(cancion21);

    }
    static public void  agregarDisco2(Disco disco2){
Cancion cancion01 = new Cancion("Dark Fantasy", "	4:40");
        Cancion cancion02 = new Cancion("Gorgeous (feat. Kid Cudi & Raekwon)", "5:57");
        Cancion cancion03 = new Cancion("Power", "	3:41");
        Cancion cancion04 = new Cancion("All of the Lights (Interlude)", "	1:02");
        Cancion cancion05 = new Cancion("All of the Lights (feat. Rihanna & Kid Cudi)", "	4:59");
        Cancion cancion06 = new Cancion("Monster (feat. Jay-Z, Rick Ross, Nicki Minaj & Bon Iver)", "6:18");
        Cancion cancion07 = new Cancion("So Appalled (feat. Jay-Z, Pusha T, Cyhi the Prynce, Swizz Beatz & RZA)", "6:38");
        Cancion cancion08 = new Cancion("Devil in a New Dress (feat. Rick Ross)", "5:52");
        Cancion cancion09 = new Cancion("Runaway (feat. Pusha T)", "	9:08");
        Cancion cancion010 = new Cancion("Hell of a Life", "5:27");
        Cancion cancion011 = new Cancion("Blame Game (feat. John Legend)", "7:49");
        Cancion cancion012= new Cancion("Lost in the World (feat. Bon Iver)", "4:17");
        Cancion cancion013= new Cancion("Who Will Survive in America", "1:38    ");
        disco2.agregarCancionesAlaLista(cancion01);
        disco2.agregarCancionesAlaLista(cancion02);
        disco2.agregarCancionesAlaLista(cancion03);
        disco2.agregarCancionesAlaLista(cancion04);
        disco2.agregarCancionesAlaLista(cancion05);
        disco2.agregarCancionesAlaLista(cancion06);
        disco2.agregarCancionesAlaLista(cancion07);
        disco2.agregarCancionesAlaLista(cancion08);
        disco2.agregarCancionesAlaLista(cancion09);
        disco2.agregarCancionesAlaLista(cancion010);
        disco2.agregarCancionesAlaLista(cancion011);
        disco2.agregarCancionesAlaLista(cancion012);
        disco2.agregarCancionesAlaLista(cancion013);
    }
    static public void  agregarDisco3(Disco disco3){
        Cancion cancion1 = new Cancion("Seasons (feat. Sam Hook)", "4:35");
        Cancion cancion2 = devolverCancion("Laugh At Em", "3:38");
        Cancion cancion3 =devolverCancion(" Big Ol Drip (feat. WATCH THE DUCK)", "3:19");
        Cancion cancion4 = devolverCancion("Wraith (feat. Yo Gotti)", "4:34");
        Cancion cancion5 =devolverCancion("The Weekend (feat. Young Thug)", "4:48");
        Cancion cancion6 = devolverCancion("The Amazing Mr. Fk Up**", "3:49");
        Cancion cancion7 = devolverCancion("At Least I Know (feat. Anderson .Paak)", "5:23");
        Cancion cancion8 = devolverCancion("What Can I Say", "3:43");
        Cancion cancion9 = devolverCancion("Jefe (feat. Meek Mill)", "3:24");
        Cancion cancion10 =devolverCancion("More & More (feat. Jeezy)", "4:26");
        Cancion cancion11 = devolverCancion("Pray for Me (feat. YFN Lucci)", "3:34");
        Cancion cancion12 = devolverCancion("Looking Back", "3:31");
        Cancion cancion13 = devolverCancion("Light Day", "3:24");
        Cancion cancion14 = devolverCancion("You (feat. Teyana Taylor)", "3:51");
        Cancion cancion15 = devolverCancion("Be There (feat. London Jae)", "5:05");
        disco3.agregarCancionesAlaLista(cancion1);
        disco3.agregarCancionesAlaLista(cancion2);
        disco3.agregarCancionesAlaLista(cancion3);
        disco3.agregarCancionesAlaLista(cancion4);
        disco3.agregarCancionesAlaLista(cancion5);
        disco3.agregarCancionesAlaLista(cancion6);
        disco3.agregarCancionesAlaLista(cancion7);
        disco3.agregarCancionesAlaLista(cancion8);
        disco3.agregarCancionesAlaLista(cancion9);
        disco3.agregarCancionesAlaLista(cancion10);
        disco3.agregarCancionesAlaLista(cancion11);
        disco3.agregarCancionesAlaLista(cancion12);
        disco3.agregarCancionesAlaLista(cancion13);
        disco3.agregarCancionesAlaLista(cancion14);
        disco3.agregarCancionesAlaLista(cancion15);
    }
    static public void agregarDisco4(Disco disco4) 
    {
         Cancion cancion1 = new Cancion("Never", "3:34");
        Cancion cancion2 = devolverCancion("D/vision", "4:09");
        Cancion cancion3 =devolverCancion("Lauder (feat. EarthGang)", "3:16");
        Cancion cancion4 = devolverCancion("Hereditary", "3:33");
        Cancion cancion5 =devolverCancion("The Never Story", "4:42");
        Cancion cancion6 = devolverCancion("All Bad (feat. Cara)", "3:56");
        Cancion cancion7 = devolverCancion("The Hiccups", "3:36");
        Cancion cancion8 = devolverCancion("In the City", "4:09");
        Cancion cancion9 = devolverCancion("D/vision (Remix)", "3:24");
        Cancion cancion10 =devolverCancion("Under the Sun (feat. Big K.R.I.T. & Rapsody)", "4:09");
        Cancion cancion11 = devolverCancion("Never Story (Outro)", "2:34");
        disco4.agregarCancionesAlaLista(cancion1);
        disco4.agregarCancionesAlaLista(cancion2);
        disco4.agregarCancionesAlaLista(cancion3);
        disco4.agregarCancionesAlaLista(cancion4);
        disco4.agregarCancionesAlaLista(cancion5);
        disco4.agregarCancionesAlaLista(cancion6);
        disco4.agregarCancionesAlaLista(cancion7);
        disco4.agregarCancionesAlaLista(cancion8);
        disco4.agregarCancionesAlaLista(cancion9);
        disco4.agregarCancionesAlaLista(cancion10);
        disco4.agregarCancionesAlaLista(cancion11);

    }
    static public void agregarDisco5(Disco disco5) {
        
    }
}