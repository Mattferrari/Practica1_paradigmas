// Clase Vehículo ----------------------------------------
public class Vehiculo
{
    private string tipo;
    private string matricula;
    private float velocidad;
    private bool flag;

    public Vehiculo(string tipo, string matricula, float velocidad, bool flag)
    {
        this.tipo = tipo;
        this.matricula = matricula;
        this.velocidad = velocidad;
        this.flag = flag;
    }
    public bool Flag
    {
        get { return flag; }
        set { flag = value; }
    }
    public float Velocidad { get { return velocidad; } set { velocidad = value; } }
    public string GetMatricula => matricula;

}

// Clase hija Coche de Policía ----------------------------
public class CochePolicia : Vehiculo
{
    public CochePolicia(string tipo, string matricula, float velocidad, bool flag) :
        base(tipo, matricula, velocidad, flag)
    { Console.WriteLine($"Coche de policía con matricula {matricula}: Creado"); }
    public void InicioPatrulla()
    {
        if (base.Flag == false)
        { base.Flag = true; }
        Console.WriteLine($"Se ha iniciado la patrulla del coche: {base.GetMatricula}");
    }
    public void FinalPatrulla()
    {
        if (base.Flag)
        { base.Flag = false; }
        Console.WriteLine($"Se ha finalizado la patrulla del coche: {base.GetMatricula}");
    }

    public void ActivarRadar(Radar radar, Vehiculo vehiculo)
    {
        if (base.Flag)
        {
            Console.WriteLine($"Se ha activado el radar ");
            radar.Disparar(vehiculo);
        }
        else { Console.WriteLine($"El coche de policia aun no se encuentra patrullando. No se ha disparado el radar"); }
    }
    public void Reporte(Radar radar)
    {
        Console.WriteLine($"Reporte de velocidades obtenidas por el coche {base.GetMatricula}: ");
        for (int i = 0; i < radar.GetRegistro.Count; i++)
        {
            if (i < radar.GetRegistro.Count - 1) { Console.WriteLine(radar.GetRegistro[i].ToString()); }
            else { Console.WriteLine(radar.GetRegistro[i].ToString() + "\n"); }

        }
    }
}

// Clase hija Taxi ---------------------------------------
public class Taxi : Vehiculo
{
    public Taxi(string tipo, string matricula, float velocidad, bool flag) :
        base(tipo, matricula, velocidad, flag)
    {    base.Velocidad = 45;
        Console.WriteLine($"Taxi con matricula {matricula}: Creado");
    }

    public void RecogerPasajeros()
    {
        if (base.Flag == false)
        {
            base.Flag = true;
            Console.WriteLine($"El taxi de matricula {base.GetMatricula} ha terminado el trayecto.");
        }
        else { Console.WriteLine($"No puedes recoger mas pasajeros"); }
        base.Velocidad = 100;
    }
    public void DejarPasajeros()
    {
        if (base.Flag == true) { base.Flag = false; }
        base.Velocidad = 45;
        Console.WriteLine($"El taxi de matricula {base.GetMatricula} ha terminado el trayecto.");
    }

}
