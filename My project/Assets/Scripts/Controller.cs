using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    public TMP_Text GnomesText;

    
    // Start is called before the first frame update
    private void Start()
    {
        data = new Data();
    }

    

    public void GnomeClick()
    {
        data.Gnomes += data.GnomesPerClick;
    }

    // Update is called once per frame
    void Update()
    {
        GnomesText.text = data.Gnomes + " Gnomes";
    }
}
