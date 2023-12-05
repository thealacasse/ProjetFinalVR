using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;



public class joueur: MonoBehaviour

{
    public GameObject bravo;
    

    public int count;

    public GameObject coquillage;
    

    public TextMeshProUGUI pointage;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {



        if (other.tag == "coquillage")
        {
            Debug.Log("coquillage");
            other.gameObject.SetActive(false);
            count++;
            pointage.text = count.ToString();
           if(count>= 2)
                 {
                      StartCoroutine("Reussite");
                 }
        }
    }
    private IEnumerator Reussite() {
        bravo.SetActive(true);
        yield return new WaitForSeconds(2f);
        yield break;
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "coquillage")
    //    {
    //        Debug.Log("coquillage");
    //        collision.gameObject.SetActive(false);

    //        count += 1;
    //        pointage.text = count.ToString();
    //        //if(count>= 0)
    //        //{
    //        //    StartCoroutine("Reussite");
    //        //}
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {



    

    }

    // Update is called once per frame

    public void MiseAZero()

    {
        
        for(int i=0; i<coquillage.transform.childCount; i++){

     coquillage.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);


     }


    }
    
   
}






