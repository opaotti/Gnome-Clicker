using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;


    public TMP_Text GpS;
    public TMP_Text GpClick;
    public TMP_Text Clicks;
    public TMP_Text GinBank;
    public TMP_Text GTOTAL;

    public TMP_Text GnomesText;

    
    // Start is called before the first frame update
    private void Start()
    {
        data = new Data();
    }

    

    public void GnomeClick()
    {
        data.Gnomes += data.GnomesPerClick;
        data.GnomeProducedTotal += data.GnomesPerClick;
        data.TotalClicks++;
    }

    // Update is called once per frame
    void Update()
    {
        GnomesText.text = data.Gnomes + " Gnomes";

        GpS.text = "GpS: " + data.GnomesPerSecond;
        GpClick.text = "Gnomes per Click: " + data.GnomesPerClick;
        Clicks.text = "Total Gnome-Clicks: " + data.TotalClicks;
        GinBank.text = "Gnomes in Bank: " + data.Gnomes;
        GTOTAL.text = " total produced Gnomes: " + data.GnomeProducedTotal;


    }
}
