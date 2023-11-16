using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiere : MonoBehaviour
{
    public GameObject eau;
    public GameObject ampoule;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "zone1")
        {
            ampoule.SetActive(true);
        }
        if (other.tag == "zoneEau")
        {
         
            eau.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "zone1")
        {
            ampoule.SetActive(false);
        }
        if (other.tag == "zoneEau")
        {
            eau.SetActive(false);
        }
    }
}



