using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using TMPro;
using System;

public class Controller : MonoBehaviour
{
    public Data data;


    public TMP_Text GpS;
    public TMP_Text GpClick;
    public TMP_Text Clicks;
    public TMP_Text GinBank;
    public TMP_Text GTOTAL;
    public TMP_Text StonksMultiText;

    public TMP_Text GnomesText;

    Vector2 a = new Vector2(10, 20);
    Vector2 b = new Vector2(0, 0);

    private double OhneKommaV;

    public int BongoCatAnzahl;



    // Start is called before the first frame update
    private void Start()
    {
        data = new Data();

        BongoCatAnzahl= data.BongoCatAnzahl;

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
        GnomesText.text = OhneKomma(data.Gnomes) + " Gnomes";

        GpS.text = "GpS: " + data.GnomesPerSecond;
        GpClick.text = "Gnomes per Click: " + data.GnomesPerClick;
        Clicks.text = "Total Gnome-Clicks: " + data.TotalClicks;
        GinBank.text = "Gnomes in Bank: " + OhneKomma(data.Gnomes);
        GTOTAL.text = " total produced Gnomes: " + OhneKomma(data.GnomeProducedTotal);
        StonksMultiText.text = "Stonks Multiplier: +" + data.StonksMulti*100 + "%";

        data.AnzahlBuildings = data.BongoCatAnzahl + data.ChadAnzahl + data.PepeAnzahl;

        ZeitTick();
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
}
