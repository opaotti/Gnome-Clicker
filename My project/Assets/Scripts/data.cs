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

    public bool BuildingsShown=true;

    public int ChadAnzahl;
    public int PepeAnzahl;
    public int BongoCatAnzahl;
    public Data()
    {
        Gnomes = 0;
        GnomesPerClick = 1;
        GnomesPerSecond = 0;
        TotalClicks = 0;
        GnomeProducedTotal = 0;
        StonksMulti = 0;

        ChadAnzahl = 0;
        PepeAnzahl = 0;
        BongoCatAnzahl=0;

        BuildingsShown= true;


    }

    
}