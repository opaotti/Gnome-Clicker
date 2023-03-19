using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class InfoPos : MonoBehaviour
{
    public GameObject Info;

    public Transform TransParent;

    private Vector3 zero = new Vector3(0, 0, 0);


    private void Start()
    {
        
        Info.transform.position = TransParent.position;
        
        Info.gameObject.SetActive(false);


        Debug.Log("TransParent: " + TransParent.position);
        Debug.Log("Info: " + Info.transform.position);
    }

    public void show()
    {
        Info.gameObject.SetActive(true);
    }

    public void hide()
    {
        Info.gameObject.SetActive(false);
    }



}
