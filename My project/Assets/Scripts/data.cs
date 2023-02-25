using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class Data
{
    public BigDouble Gnomes;
    public BigDouble GnomesPerClick;
    public BigDouble GnomesPerSecond;
    public BigDouble TotalClicks;
    public BigDouble GnomeProducedTotal;

    public Data()
    {
        Gnomes = 0;
        GnomesPerClick = 1;
        GnomesPerSecond = 0;
        TotalClicks = 0;
        GnomeProducedTotal = 0;
    }

    
}