using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using TMPro;
using System;
using System.IO;

public class Controller : MonoBehaviour
{
    public Data data;



    public TMP_Text GnomesText;

    Vector2 a = new Vector2(10, 20);
    Vector2 b = new Vector2(0, 0);

    private double OhneKommaV;

    public int BongoCatAnzahl;

    public GameObject Upgrades;
    public GameObject Buildings;

    string path = "E:\\Roman\\IT\\GitHub\\Gnome-Clicker\\My project\\Assets\\Scripts\\IDs.txt";
    string[] lines;


    // Start is called before the first frame update
    private void Start()
    {
        data = new Data();

        BongoCatAnzahl= data.BongoCatAnzahl;

    }

    public void BuildingsShow()
    {
        data.BuildingsShown = true;
        Debug.Log("buildings sollten angezeigt werden");
    }

    public void UpgradeShow()
    {
        data.BuildingsShown= false;
        Debug.Log("upgrades sollten angezeigt werden");
    }

    public void GnomeClick()
    {
        data.Gnomes += data.GnomesPerClick*data.ClickMulti;
        data.GnomeProducedTotal += data.GnomesPerClick*data.ClickMulti;
        data.TotalClicks++;
    }

    // Update is called once per frame
    void Update()
    {
        IdTxtUpdate();

        GnomesText.text = OhneKomma(data.Gnomes) + " Gnomes";

        data.AnzahlBuildings = data.BongoCatAnzahl + data.ChadAnzahl + data.PepeAnzahl;

        ZeitTick();

        Upgrades.SetActive(!data.BuildingsShown);
        Buildings.SetActive(data.BuildingsShown);


    }

    public void BuyBuilding(double AktuellerPrice, int owned, int freeOwned)
    {
        if (data.Gnomes >= AktuellerPrice)
        {
            data.Gnomes -= AktuellerPrice;
            AktuellerPrice = NewPriceB(AktuellerPrice, owned, freeOwned);
            owned++;
        }
    }

    public double NewPriceB(double OldPrice, double BuildingsOwned, double FreeBuildingOwned)
    {
        return OldPrice * Math.Pow(1.15, BuildingsOwned - FreeBuildingOwned);
    }

    public void BuyB(int ID, int Anzahl)
    {
        if (ID == 0)
        {
            Debug.Log("war nen Test");
        }
        if (ID == 1)
        {
            data.ChadAnzahl += Anzahl;
        }
        if (ID == 2)
        {
            data.PepeAnzahl += Anzahl;
        }
        if (ID == 3)
        {
            data.BongoCatAnzahl += Anzahl;
        }
        
    }

    public void ZeitTick()
    {
        System.Threading.Thread.Sleep(10); //0.01 Sekunde
        data.Gnomes += data.GnomesPerSecond*0.01*(data.StonksMulti+1) +      (data.AnzahlBuildings-data.ChadAnzahl)*data.ChadExtra*data.ChadAnzahl;
        data.GnomeProducedTotal += data.GnomesPerSecond*0.01 * (data.StonksMulti + 1);

    }

    public double OhneKomma(double Nummer)
    {
        OhneKommaV = Nummer;
        while (OhneKommaV >= 1)
        {
            OhneKommaV--;
        }
        return Nummer - OhneKommaV;
    }

   public void Hack()
    {
        data.Gnomes += 10000;
    }

    void IdTxtUpdate()
    {
        lines = File.ReadAllLines(path);

        lines[1] = new string (data.ChadAnzahl.ToString());
        lines[2] = new string (data.PepeAnzahl.ToString());
        lines[3] = new string(data.BongoCatAnzahl.ToString());

        File.WriteAllLines(path, lines);    
    }

    public void returnButton()
    {
        lines= File.ReadAllLines(path);


        Debug.Log("Chad: " + lines[2]);
        Debug.Log("Pepe: " + lines[3]);
        Debug.Log("Bongo: " + lines[4]);
        Debug.Log("Cat: " + data.BongoCatAnzahl);
        Debug.Log("--------------------------------------");
    }

}
