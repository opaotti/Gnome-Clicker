using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using System;   
using System.IO;

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

    public int ChadAnzahl = 0;
    public double ChadMulti = 1;
    public double ChadExtra = 0;
    public int PepeAnzahl = 0;
    public double PepeMulti = 1;
    public int BongoCatAnzahl = 0;
    public double BongoCatMulti = 1;
    
    public string path = "E:\\Roman\\IT\\GitHub\\Gnome-Clicker\\My project\\Assets\\Scripts\\IDs.txt";

    string[] lines;

    public int UpgradesShowed=0; //Anzahl Upgrades die angezeigt werden

    public Dictionary<int, string> IDNames = new Dictionary<int, string>
    {
        {1, "Chad"},
        {2, "Pepe" },
        {3, "Bongo Cat" }
    };
    

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



    }

    
}