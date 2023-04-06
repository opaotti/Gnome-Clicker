using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{

    public TMP_Text GpS;
    public TMP_Text GpClick;
    public TMP_Text Clicks;
    public TMP_Text GinBank;
    public TMP_Text GTOTAL;
    public TMP_Text AnzahlBuildings;
    public TMP_Text StonksMulti;

    public Controller controller;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GpS.text = "GpS: " + controller.data.GnomesPerSecond;
        GpClick.text = "Gnomes per Click: " + controller.OhneKomma(controller.data.GnomesPerClick);
        Clicks.text = "Total Gnome-Clicks: " + controller.data.TotalClicks;
        GinBank.text = "Gnomes in Bank: " + controller.OhneKomma(controller.data.Gnomes);
        GTOTAL.text = " total produced Gnomes: " + controller.OhneKomma(controller.data.GnomeProducedTotal);
        AnzahlBuildings.text = "Anzahl Buildings: " + controller.data.AnzahlBuildings;
        StonksMulti.text = "Total Stonks: " + controller.data.StonksMulti + "%";

    }
}
