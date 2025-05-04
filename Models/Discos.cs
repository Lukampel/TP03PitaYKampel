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
        Disco disco4 = new Disco(004, artista4, productor4, "/Images/TNS.png", "Hip Hop", "The Never Story", new DateTime(2017, 3, 10));
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
    static public void agregarDisco5(Disco disco5) 
    {
        Cancion cancion1 = devolverCancion("Si Veo a Tu Mamá", "2:50");
Cancion cancion2 = devolverCancion("La Difícil", "2:59");
Cancion cancion3 = devolverCancion("Pero Ya No", "3:47");
Cancion cancion4 = devolverCancion("La Santa (feat. Daddy Yankee)", "3:26");
Cancion cancion5 = devolverCancion("Yo Perreo Sola", "3:16");
Cancion cancion6 = devolverCancion("Bichiyal (feat. Yaviah)", "3:17");
Cancion cancion7 = devolverCancion("Soliá", "3:33");
Cancion cancion8 = devolverCancion("La Zona", "2:47");
Cancion cancion9 = devolverCancion("Que Malo (feat. Ñengo Flow)", "3:26");
Cancion cancion10 = devolverCancion("Vete", "3:12");
Cancion cancion11 = devolverCancion("Ignorantes (feat. Sech)", "3:32");
Cancion cancion12 = devolverCancion("A Tu Merced", "2:54");
Cancion cancion13 = devolverCancion("Una Vez (feat. Mora)", "2:43");
Cancion cancion14 = devolverCancion("Safaera (feat. Jowell & Randy and Ñengo Flow)", "4:55");
Cancion cancion15 = devolverCancion("25/8", "2:56");
Cancion cancion16 = devolverCancion("Está Cabrón Ser Yo (feat. Anuel AA)", "3:00");
Cancion cancion17 = devolverCancion("Puesto Pa' Guerrial", "2:57");
Cancion cancion18 = devolverCancion("P FKN R (feat. Kendo Kaponi and Arcángel)", "3:44");
Cancion cancion19 = devolverCancion("Hablamos Mañana (feat. Duki and Pablo Chill-E)", "3:39");
Cancion cancion20 = devolverCancion("<3", "3:34");

disco5.agregarCancionesAlaLista(cancion1);
disco5.agregarCancionesAlaLista(cancion2);
disco5.agregarCancionesAlaLista(cancion3);
disco5.agregarCancionesAlaLista(cancion4);
disco5.agregarCancionesAlaLista(cancion5);
disco5.agregarCancionesAlaLista(cancion6);
disco5.agregarCancionesAlaLista(cancion7);
disco5.agregarCancionesAlaLista(cancion8);
disco5.agregarCancionesAlaLista(cancion9);
disco5.agregarCancionesAlaLista(cancion10);
disco5.agregarCancionesAlaLista(cancion11);
disco5.agregarCancionesAlaLista(cancion12);
disco5.agregarCancionesAlaLista(cancion13);
disco5.agregarCancionesAlaLista(cancion14);
disco5.agregarCancionesAlaLista(cancion15);
disco5.agregarCancionesAlaLista(cancion16);
disco5.agregarCancionesAlaLista(cancion17);
disco5.agregarCancionesAlaLista(cancion18);
disco5.agregarCancionesAlaLista(cancion19);
disco5.agregarCancionesAlaLista(cancion20);
    }

    static public void agregarDisco6(Disco disco6) 
    {
        Cancion cancion1 = devolverCancion("Amarillo", "2:43");
Cancion cancion2 = devolverCancion("Azul", "2:45");
Cancion cancion3 = devolverCancion("Rojo", "3:36");
Cancion cancion4 = devolverCancion("Rosa", "2:56");
Cancion cancion5 = devolverCancion("Morado", "2:51");
Cancion cancion6 = devolverCancion("Verde", "2:50");
Cancion cancion7 = devolverCancion("Negro", "3:00");
Cancion cancion8 = devolverCancion("Gris", "2:51");
Cancion cancion9 = devolverCancion("Arcoíris (feat. Mr Eazi)", "2:55");
Cancion cancion10 = devolverCancion("Blanco", "2:26");

disco6.agregarCancionesAlaLista(cancion1);
disco6.agregarCancionesAlaLista(cancion2);
disco6.agregarCancionesAlaLista(cancion3);
disco6.agregarCancionesAlaLista(cancion4);
disco6.agregarCancionesAlaLista(cancion5);
disco6.agregarCancionesAlaLista(cancion6);
disco6.agregarCancionesAlaLista(cancion7);
disco6.agregarCancionesAlaLista(cancion8);
disco6.agregarCancionesAlaLista(cancion9);
disco6.agregarCancionesAlaLista(cancion10);
    }

static public void agregarDisco7(Disco disco7) 
{
    Cancion cancion1 = devolverCancion("Ocean", "3:33");
Cancion cancion2 = devolverCancion("Love with a Quality (feat. Damian Marley)", "3:45");
Cancion cancion3 = devolverCancion("Baby", "3:40");
Cancion cancion4 = devolverCancion("Punto G", "3:36");
Cancion cancion5 = devolverCancion("Culpables (feat. Anuel AA)", "3:35");
Cancion cancion6 = devolverCancion("Dices Que Te Vas (feat. Anuel AA)", "3:28");
Cancion cancion7 = devolverCancion("La Vida Continuó", "3:09");
Cancion cancion8 = devolverCancion("Mi Cama (Remix)", "3:34");
Cancion cancion9 = devolverCancion("Créeme (feat. Maluma)", "3:23");
Cancion cancion10 = devolverCancion("Pineapple", "3:27");
Cancion cancion11 = devolverCancion("Ocean (Acoustic)", "3:33");
Cancion cancion12 = devolverCancion("Ocean (Remix)", "3:33");
Cancion cancion13 = devolverCancion("Ocean (Piano Version)", "3:33");
Cancion cancion14 = devolverCancion("Ocean (Live)", "3:33");
Cancion cancion15 = devolverCancion("Ocean (Instrumental)", "3:33");
Cancion cancion16 = devolverCancion("Ocean (Extended Version)", "3:33");

disco7.agregarCancionesAlaLista(cancion1);
disco7.agregarCancionesAlaLista(cancion2);
disco7.agregarCancionesAlaLista(cancion3);
disco7.agregarCancionesAlaLista(cancion4);
disco7.agregarCancionesAlaLista(cancion5);
disco7.agregarCancionesAlaLista(cancion6);
disco7.agregarCancionesAlaLista(cancion7);
disco7.agregarCancionesAlaLista(cancion8);
disco7.agregarCancionesAlaLista(cancion9);
disco7.agregarCancionesAlaLista(cancion10);
disco7.agregarCancionesAlaLista(cancion11);
disco7.agregarCancionesAlaLista(cancion12);
disco7.agregarCancionesAlaLista(cancion13);
disco7.agregarCancionesAlaLista(cancion14);
disco7.agregarCancionesAlaLista(cancion15);
disco7.agregarCancionesAlaLista(cancion16);
}
static public void agregarDisco8(Disco disco8) 
{
    Cancion cancion1 = devolverCancion("Na' Nuevo", "3:22");
Cancion cancion2 = devolverCancion("Quiere Beber", "3:04");
Cancion cancion3 = devolverCancion("Hipócrita (feat. Zion)", "3:49");
Cancion cancion4 = devolverCancion("Modo Avión", "3:00");
Cancion cancion5 = devolverCancion("Bandolera", "3:10");
Cancion cancion6 = devolverCancion("Pensando en Ti (feat. Wisin)", "3:28");
Cancion cancion7 = devolverCancion("Brindemos (feat. Ozuna)", "3:27");
Cancion cancion8 = devolverCancion("Espina", "3:38");
Cancion cancion9 = devolverCancion("Tú No Lo Amas", "3:33");
Cancion cancion10 = devolverCancion("Naturaleza", "3:38");
Cancion cancion11 = devolverCancion("Las Yeezy (feat. Ñengo Flow)", "3:36");
Cancion cancion12 = devolverCancion("Te Necesito", "3:34");

disco8.agregarCancionesAlaLista(cancion1);
disco8.agregarCancionesAlaLista(cancion2);
disco8.agregarCancionesAlaLista(cancion3);
disco8.agregarCancionesAlaLista(cancion4);
disco8.agregarCancionesAlaLista(cancion5);
disco8.agregarCancionesAlaLista(cancion6);
disco8.agregarCancionesAlaLista(cancion7);
disco8.agregarCancionesAlaLista(cancion8);
disco8.agregarCancionesAlaLista(cancion9);
disco8.agregarCancionesAlaLista(cancion10);
disco8.agregarCancionesAlaLista(cancion11);
disco8.agregarCancionesAlaLista(cancion12);
}
static public void agregarDisco9(Disco disco9) 
{
    Cancion cancion1 = devolverCancion("DESFILAR MIS PENAS", "2:31");
Cancion cancion2 = devolverCancion("BARDOS Y VERDADES", "1:47");
Cancion cancion3 = devolverCancion("COMO TIENE QUE SER", "2:37");
Cancion cancion4 = devolverCancion("CALOR", "2:31");
Cancion cancion5 = devolverCancion("FULL ICE", "2:27");
Cancion cancion6 = devolverCancion("NEGOCIANDO POR TIEMPO", "2:28");
Cancion cancion7 = devolverCancion("BUENOS AIRES ES AMOR", "2:45");
Cancion cancion8 = devolverCancion("DONDE LAS LUCES", "2:34");
Cancion cancion9 = devolverCancion("ALMA", "2:36");
Cancion cancion10 = devolverCancion("PARA SACÁRMELO", "2:33");
Cancion cancion11 = devolverCancion("TANTAS TENTACIONES", "2:50");

disco9.agregarCancionesAlaLista(cancion1);
disco9.agregarCancionesAlaLista(cancion2);
disco9.agregarCancionesAlaLista(cancion3);
disco9.agregarCancionesAlaLista(cancion4);
disco9.agregarCancionesAlaLista(cancion5);
disco9.agregarCancionesAlaLista(cancion6);
disco9.agregarCancionesAlaLista(cancion7);
disco9.agregarCancionesAlaLista(cancion8);
disco9.agregarCancionesAlaLista(cancion9);
disco9.agregarCancionesAlaLista(cancion10);
disco9.agregarCancionesAlaLista(cancion11);
}
static public void agregarDisco10(Disco disco10) 
{
    Cancion cancion1 = devolverCancion("Pornography", "3:51");
Cancion cancion2 = devolverCancion("Oh My Dis Side (feat. Quavo)", "5:51");
Cancion cancion3 = devolverCancion("3500 (feat. Future & 2 Chainz)", "7:41");
Cancion cancion4 = devolverCancion("Wasted (feat. Juicy J)", "3:55");
Cancion cancion5 = devolverCancion("90210 (feat. Kacy Hill)", "5:39");
Cancion cancion6 = devolverCancion("Pray 4 Love (feat. The Weeknd)", "5:07");
Cancion cancion7 = devolverCancion("Nightcrawler (feat. Swae Lee & Chief Keef)", "5:21");
Cancion cancion8 = devolverCancion("Piss on Your Grave (feat. Kanye West)", "2:46");
Cancion cancion9 = devolverCancion("Antidote", "4:22");
Cancion cancion10 = devolverCancion("Impossible", "4:02");
Cancion cancion11 = devolverCancion("Maria I'm Drunk (feat. Justin Bieber & Young Thug)", "5:49");
Cancion cancion12 = devolverCancion("Flying High (feat. Toro y Moi)", "3:28");
Cancion cancion13 = devolverCancion("I Can Tell", "3:55");
Cancion cancion14 = devolverCancion("Apple Pie", "3:39");
Cancion cancion15 = devolverCancion("Ok Alright (feat. Schoolboy Q)", "6:57");
Cancion cancion16 = devolverCancion("Never Catch Me", "2:56");

disco10.agregarCancionesAlaLista(cancion1);
disco10.agregarCancionesAlaLista(cancion2);
disco10.agregarCancionesAlaLista(cancion3);
disco10.agregarCancionesAlaLista(cancion4);
disco10.agregarCancionesAlaLista(cancion5);
disco10.agregarCancionesAlaLista(cancion6);
disco10.agregarCancionesAlaLista(cancion7);
disco10.agregarCancionesAlaLista(cancion8);
disco10.agregarCancionesAlaLista(cancion9);
disco10.agregarCancionesAlaLista(cancion10);
disco10.agregarCancionesAlaLista(cancion11);
disco10.agregarCancionesAlaLista(cancion12);
disco10.agregarCancionesAlaLista(cancion13);
disco10.agregarCancionesAlaLista(cancion14);
disco10.agregarCancionesAlaLista(cancion15);
disco10.agregarCancionesAlaLista(cancion16);
}

public static Dictionary<int, Disco> devolverDiccionario() {
        return discos;
    }
}