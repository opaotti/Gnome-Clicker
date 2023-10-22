using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class UpgradeScript : MonoBehaviour
{
    public int type; //0= test; 1= Stonks percent; 2= building; 3= extra
    public float percent; //nur wenn type == 1
    public int ID; //nur wenn type == 2 -> ID des Buildings
    public int IDBuild; //ID==1: double; ID==2: cursorSpecial; ID==3: Cursor+Click; ID==4: Grandma extra
    public int IDextra; //nur wenn type == 3 -> z.B. cursor, katzen, usw.

    public double price;
    public double unlock; //Anzahl Gnomes/Buildings die total produziert/gekauft werden sollten
    public string Name;
    public double ChadExtra; // bei chad anzahl für alle nicht Chad Objekte so und so viele gps mehr
    public int PepeExtra; //-> IDBuild==4 -> bei welche Gebäude Pepe bonus aktiviert wird s.b. Miner-Oma

    public Controller controller;

    public GameObject Upgrade;
    public GameObject Info;
    public GameObject ZENTRUM;

    bool shown = false;

    public TMP_Text StonksText;
    public TMP_Text InfoNameText;
    public TMP_Text InfoDescription;
    public TMP_Text BuyText;

    //für sachen mit stonks:
    public GameObject NameGO;
    public GameObject StonksImage;

    //für sachen mit was anderem:
    public GameObject ProfilImage;
    public GameObject InfoButton;

    public Transform Transformas;
    public Scrollbar scrollbar;

    private int nummer; // gibt an an welcher stelle das Upgrade steht

    string path = "E:\\Roman\\IT\\GitHub\\Gnome-Clicker\\My project\\Assets\\Scripts\\IDs.txt";

    string line;

    public int PepeExtraAnzahl; //wird zur Initialisierung definiert. Damit das Programm weiß welcher Wert über 15 sein muss

    public void Buy()
    {
        if (controller.data.Gnomes >= price)
        {
            controller.data.Gnomes -= price;
            
            if (type == 1)
            {
                controller.data.StonksMulti += percent;
            }
            if (type == 2)
            {
                if (ID == 2)
                {
                    controller.data.PepeMulti *= 2;
                }
                if (ID == 3)
                {
                    controller.data.BongoCatMulti *= 2;
                }

                if (IDBuild == 2)
                {
                    controller.data.ChadExtra += ChadExtra;
                }
                if(IDBuild == 3)
                {
                    controller.data.ClickMulti *= 2;
                    controller.data.ChadMulti *= 2;
                }
                if(IDBuild == 4)
                {
                    if (PepeExtra == 3)
                    {
                        controller.data.BongoCatMulti += 0.01 * (controller.data.PepeAnzahl / (PepeExtra - 1));
                    }
                }
                controller.data.UpgradesShowed--;
            }
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (ID <= 0)
        {
            ID = 1;
        }
        
        shown = false;

        Upgrade.SetActive(false);

        Info.SetActive(false);

        BuyText.text = "Buy: " + price.ToString() + " Gnomes";
        Info.transform.position = ZENTRUM.transform.position;

        /*
        if (controller.data.IDNames[ID] != null)
        {
            Name = controller.data.IDNames[ID];
        }
        */



        InfoNameText.text = Name + " Power-Up";

        if (IDBuild == 1)
        {
            InfoDescription.text = Name + " macht jetzt doppelt so viel Gnomes pro Sekunde.";
        }
        if (IDBuild == 2)
        {
            InfoDescription.text = Name + " kriegt +" + ChadExtra + " für jeden nicht-Chad";
        }
        if (IDBuild == 3)
        {
            InfoDescription.text = Name + " macht doppelt so viele Gnomes pro Sekunde und zusätzlich wird auch die Gnomes-per-Click verdoppelt.";
        }
        if (IDBuild == 4 & controller.data.PepeAnzahl>0 & PepeExtraAnzahl>=15)
        {
            InfoDescription.text = controller.data.IDNames[PepeExtra] + " macht für jeden " + (PepeExtra - 1) + ". Pepe 1% Gnome pro Sekunde mehr. Pepe macht selbst nochmal 2-mal so viel wie davor!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (shown == false)
        {
            if (type == 0)
            {
                Debug.Log("war nen Upgrade test");
            }
            if (type == 1)
            {
                StonksText.text = (percent * 100).ToString() + "% Stonks";
                if (controller.data.GnomeProducedTotal >= unlock)
                {
                    controller.data.UpgradesShowed++;
                    shown = true;
                }



            }
            if (type == 2)
            {
                if ((ID == 1 & controller.data.ChadAnzahl >= unlock) || (ID == 2 & controller.data.PepeAnzahl >= unlock) || (ID == 3 & controller.data.BongoCatAnzahl >= unlock))
                {
                    shown = true;
                    controller.data.UpgradesShowed++;
                }
            }

        }
        else
        {
            Upgrade.SetActive(true);
            if (type == 1)
            {
                Stonks(true);
            }
            else
            {
                Stonks(false);
            }

            platzieren();
        }
    }

    void Stonks(bool wirklich)
    {
        if (wirklich)
        {
            NameGO.SetActive(true);
            StonksImage.SetActive(true);
            ProfilImage.SetActive(false);
            InfoButton.SetActive(false);
        }
        else
        {
            NameGO.SetActive(false);
            StonksImage.SetActive(false);
            ProfilImage.SetActive(true);
            InfoButton.SetActive(true);
        }
    }

    void platzieren()
    {//                                      Platz in der Reihe+             Abstand                     -    scrollbar
        Transformas.position += new Vector3(0, -(nummer * 50 + (controller.data.UpgradesShowed - 1) * 10 - scrollbar.value*30), 0);
    }

    public void InfoAnzeigen()
    {
        Info.SetActive(true);
        Upgrade.transform.SetAsLastSibling();
    }

    public void InfoSchliessen()
    {
        Info.SetActive(false);
    }




}