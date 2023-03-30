using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
    
    public void Buy()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        Upgrade.SetActive(false);

        Info.SetActive(false);

        BuyText.text = "Buy: " + price.ToString() + " Gnomes";
        Info.transform.position = ZENTRUM.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (type== 0)
        {
            Debug.Log("war nen Upgrade test");
        }
        if (type== 1)
        {
            StonksText.text = (percent*100).ToString() + "% Stonks";
            if (controller.data.GnomeProducedTotal>= unlock)
            {
                controller.data.UpgradesShowed++;
                shown= true;
            }
        }
        if (type== 2)
        {
            if (ID == 1 & controller.data.ChadAnzahl>= unlock)
            {
                controller.data.UpgradesShowed++;
                shown = true;
            }
            if (ID == 2 & controller.data.PepeAnzahl>= unlock)
            {
                controller.data.UpgradesShowed++;
                shown = true;
            }
            if(ID == 3 & controller.data.BongoCatAnzahl>= unlock)
            {
                controller.data.UpgradesShowed++;
                shown = true;
            }

            Name = controller.data.IDNames[ID];
            InfoNameText.text = Name + " Power-Up";
            
            if(IDBuild == 1)
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
            if (IDBuild == 4)
            {
                InfoDescription.text = controller.data.IDNames[PepeExtra] + " macht für jeden " + PepeExtra + ". 1% Gnome pro Sekunde mehr.";
            }
        }
    }
}
