using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;


public class requiguingue : MonoBehaviour

{
    public GameObject coquillage;
    public int count;

    public TextMeshProUGUI pointage;

    // Start is called before the first frame update
    //private void OnTriggerEnter(Collider other)
    //{

    

    //     if (other.tag == "coquillage")
    //    {
    //        Debug.Log("coquillage");
    //        other.gameObject.SetActive(false);
    //        count++;
    //        //pointage.text = count.ToString();
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coquillage")
        {
            Debug.Log("coquillage");
            collision.gameObject.SetActive(false);
            count++;
            pointage.text = count.ToString();
            if(count>= 0)
            {
                StartCoroutine("Reussite");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {



    

    }

    // Update is called once per frame

    public void MiseAZero()

    {
        count = 0;
        for(int i=0; i<coquillage.transform.childCount; i++){

     coquillage.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);


     }


    }
    
   
}






