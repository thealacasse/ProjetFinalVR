using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class requiguingue: MonoBehaviour

{
    public GameObject coquillage;
    public int count;
    
    public GameObject eau;
    public TextMeshProUGUI pointage;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
       
      
      
       
        if (other.tag == "zoneEau")
        {

            eau.SetActive(true);
        }
        else if (other.tag == "coquillage")
        {
            other.gameObject.SetActive(false);
            count++;
            pointage.text = count.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {

   
    
        if (other.tag == "zoneEau")
        {
            eau.SetActive(false);
        }
     

    }

    // Update is called once per frame

    /*  public void MiseAZero()

    {
        count = 0;
        for(int i=0; i<coquillage.transform.childCount; i++){

     coquillage.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);


     }


    }*/
}





