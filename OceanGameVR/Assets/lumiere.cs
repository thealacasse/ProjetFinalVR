using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiere : MonoBehaviour
{
    public GameObject ampoule;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "zone1")
        {
            ampoule.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "zone1")
        {
            ampoule.SetActive(false);
        }
    }
}



