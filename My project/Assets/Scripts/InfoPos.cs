using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPos : MonoBehaviour
{
    public GameObject Info;

    private Vector3 zero = new Vector3(0, 0, 0);

    Transform PosPrefab;

    private void Start()
    {
        Info.transform.position = zero - PosPrefab.position;
    }



}
