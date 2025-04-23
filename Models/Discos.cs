namespace TP03PitaYKampel.Models;

public class Discos
{
static public Dictionary<int, Disco> discos { get; private set; }
public static void InicializarDiscos()
    {
        discos = new Dictionary<int, Disco>();
        DatoPersonal datoPersonal1 = new DatoPersonal("Rami", "Pita", new DateTime(2009, 04, 11), "/Images/RAMI.png");
        DatoFamiliar datoFamiliar1 = new DatoFamiliar("Eva", "Wizenberg", "mamá", "es mi mamá");
        DatoFamiliar datoFamiliar2 = new DatoFamiliar("Leo", "Pita", "papá", "es mi papá");
        DatosInteres datosInteres = new DatosInteres("El colegio", "Los Simpson", "Los pibes", "Pollín");
        Integrante integrante1= new Integrante (49261291, datoPersonal1, datosInteres);
        integrante1.agregarDatosFamiliares(datoFamiliar1, datoFamiliar2);

        DatoPersonal datoPersonal2 = new DatoPersonal("Lu", "Kampel", new DateTime(2008, 08, 04), "/Images/LU.png");
        DatoFamiliar datoFamiliar4 = new DatoFamiliar("Jessi", "Goldfarb", "mamá", "es mi mamá");
        DatoFamiliar datoFamiliar3 = new DatoFamiliar("Diego", "Kampel", "papá", "es mi papá");
        DatosInteres datosInteres1 = new DatosInteres("hockey", "Brooklyn 99", "Las chicas", "Historia");
        Integrante integrante2= new Integrante (48860067, datoPersonal2, datosInteres1);
        integrante2.agregarDatosFamiliares(datoFamiliar3, datoFamiliar4);

        discos.Add(49261291, disco1);
        discos.Add(48860067, disco2);
    }
    static public Dictionary<int,Disco> Devolverdiscos(){
        return discos;
    }
}