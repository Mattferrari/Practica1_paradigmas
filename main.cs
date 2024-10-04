class Programa
{
    static void Main()
    {
        Radar radar1 = new Radar();
        Radar radar2 = new Radar();
        Taxi taxi1 = new Taxi("Taxi", "0001 AAA", 0, false);
        Taxi taxi2 = new Taxi("Taxi", "0002 BBB", 0, false);
        CochePolicia policia1 = new CochePolicia("CochePolicia", "0001 CNP", 0, false);
        CochePolicia policia2 = new CochePolicia("CochePolicia", "0002 CNP", 0, false);

        policia1.InicioPatrulla();
        policia1.ActivarRadar(radar1, taxi1);
        taxi2.RecogerPasajeros();
        policia2.ActivarRadar(radar2, taxi2);
        policia2.InicioPatrulla();
        policia2.ActivarRadar(radar2, taxi2);
        taxi2.DejarPasajeros();
        policia2.FinalPatrulla();
        taxi1.RecogerPasajeros();
        policia1.InicioPatrulla();
        policia1.ActivarRadar(radar1, taxi1);
        policia1.FinalPatrulla();

        policia1.Reporte(radar1);
        policia2.Reporte(radar2);
     }
}
