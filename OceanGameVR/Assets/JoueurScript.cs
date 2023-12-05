using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurScript : MonoBehaviour
{

    public Script joueur;

    public void compte()
    {
        joueur.count += 1;
    }
    public GameObject ZoneCristaux;

    private void OnTriggerEnter(Collider other)
    {



     if (other.tag == "zone1")
       {
          Debug.Log("coquillage");
            ZoneCristaux.SetActive(false);

        }
        else
        {
            ZoneCristaux.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
