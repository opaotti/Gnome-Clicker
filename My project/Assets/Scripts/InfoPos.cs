using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class InfoPos : MonoBehaviour
{
    public GameObject Info;

    public Transform TransParent;

    private Vector3 zero = new Vector3(0, 0, -1);

    public TMP_Text InfoText;
    public TMP_Text NameText;
    public TMP_Text GpSText;

    public BuyingBuilding BuyingBuilding;

    public string Description;

    public GameObject Profil;
    public GameObject ProfilInfo;


    private void Start()
    {
        
        Info.transform.position = TransParent.position;
        
        Info.gameObject.SetActive(false);

        NameText.text = BuyingBuilding.Name;
        GpSText.text = BuyingBuilding.GpSB.ToString() + " GpS";
        InfoText.text = Description;


    }

    public void show()
    {
        Info.gameObject.SetActive(true);
        //Info.layer= 20;
    }

    public void hide()
    {
        Info.gameObject.SetActive(false);
    }

    



}
