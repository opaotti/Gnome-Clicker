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

    public Data data;


    // Start is called before the first frame update
    void Start()
    {
        data = new Data();
    }

    // Update is called once per frame
    void Update()
    {
        GpS.text = "GpS: " + data.GnomesPerSecond;
        GpClick.text = "Gnomes per Click: " + data.GnomesPerClick;
        Clicks.text = "Total Gnome-Clicks: " + data.TotalClicks;
        GinBank.text = "Gnomes in Bank: " + data.Gnomes;
        GTOTAL.text = " total produced Gnomes: " + data.GnomeProducedTotal;
    }
}
