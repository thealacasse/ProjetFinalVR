using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class requiguingue: MonoBehaviour

{
    public int count;
    
    public GameObject eau;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
       
      
      
       
        if (other.tag == "zoneEau")
        {

            eau.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

   
    
        if (other.tag == "zoneEau")
        {
            eau.SetActive(false);
        }
        else if (other.tag == "coquillage")
        {
            other.gameObject.SetActive(false);
            count++;
        }

    }

    // Update is called once per frame

    //   public void MiseAZero()

    // {for(int i=0; i<coquillage.transform.childCount; i++){

    //  coquillage.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);

    // }


    // }
}





