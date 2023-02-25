using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using System;

public class Price : MonoBehaviour
{
    

    public BigDouble NewPrice(BigDouble OldPrice, double BuildingsOwned, double FreeBuildingOwned)
    {
        return OldPrice * Math.Pow(1.15, BuildingsOwned - FreeBuildingOwned);
    }
    /*
    public void Buy()
    {
        
    }
    */
}
