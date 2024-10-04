using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


public class Radar
{
    private int limite = 50;
    private List<float> registroVelocidades;
    public Radar()
    {
        this.registroVelocidades = new List<float>();
    }

    public List<float> GetRegistro => registroVelocidades;
    public virtual void Disparar(Vehiculo vehiculo)
    {
        Console.WriteLine($"La velocidad del vehiculo {vehiculo.GetMatricula} es de {vehiculo.Velocidad} km/h");
        registroVelocidades.Add(vehiculo.Velocidad);

        if (vehiculo.Velocidad > limite)
        {
            Console.WriteLine($"La velocidad es superior a la permitida");
        }
        else { Console.WriteLine($"La velocidad es inferior al limite impuesto. MULTON"); }
    }
}