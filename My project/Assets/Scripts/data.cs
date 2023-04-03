using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class Data
{
    public double Gnomes;
    public double GnomesPerClick;
    public double GnomesPerSecond;
    public double TotalClicks;
    public double GnomeProducedTotal;
    public double StonksMulti;
    public int AnzahlBuildings;


    public bool BuildingsShown=true;

    public int ClickMulti;

    public int ChadAnzahl;
    public double ChadMulti;
    public double ChadExtra;
    public int PepeAnzahl;
    public double PepeMulti;
    public int BongoCatAnzahl;
    public double BongoCatMulti;

    public int UpgradesShowed=0; //Anzahl Upgrades die angezeigt werden

    public Dictionary<int, string> IDNames = new Dictionary<int, string>();
    

    public Data()
    {
        AnzahlBuildings= 0;
        Gnomes = 0;
        GnomesPerClick = 1;
        GnomesPerSecond = 0;
        TotalClicks = 0;
        GnomeProducedTotal = 0;
        StonksMulti = 0;

        ClickMulti = 1;

        ChadAnzahl = 0;
        ChadMulti = 1;
        ChadExtra = 0;
                
        PepeAnzahl = 0;
        PepeMulti = 1;
        
        BongoCatAnzahl=0;
        BongoCatMulti = 1;

        BuildingsShown= true;

        IDNames.Add(1, "Chad");
        IDNames.Add(2, "Pepe");
        IDNames.Add(3, "Bongo Cat");


    }

    
}