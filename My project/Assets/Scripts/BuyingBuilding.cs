using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using System;
using TMPro;

public class BuyingBuilding : MonoBehaviour
{
    
    public Controller controller;

    public double AktuellerPriceB;
    public int owned = 0;
    private int freeOwned = 0;
    public double StartPrice;
    public int ID;

    public double GpSB = 0;

    public TMP_Text PriceText;
    public TMP_Text OwnedText;
    public TMP_Text NameText;

    public GameObject Building;

    public string Name = "Mr. X";

    private void Start()
    {
        AktuellerPriceB = StartPrice;

        OwnedText.text = owned.ToString();
        PriceText.text = "Buy: " + "\n" + StartPrice.ToString() + " Gnomes";
        NameText.text = Name;
    }

    

    public void BuyBuilding()
    {
        
        if (controller.data.Gnomes >= AktuellerPriceB)
        {
            owned++;
            controller.data.GnomesPerSecond += GpSB;
            controller.data.Gnomes -= AktuellerPriceB;
            AktuellerPriceB = controller.OhneKomma(StartPrice * Math.Pow(1.15, (owned - freeOwned)))+1;
            controller.BuyB(ID, 1);
            PriceText.text = "Buy: " + AktuellerPriceB.ToString() + " " + " Gnomes";
            OwnedText.text = owned.ToString();
        }
    }

    private void Update()
    {
        Building.SetActive(controller.data.BuildingsShown);
    }






}
