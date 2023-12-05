using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class JoueurScript : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {



        if (other.tag == "joueur")
        {
            Debug.Log("coquillage");
            gameObject.GetComponent<AudioSource>().Play(); 

        }
       
    }

    private void OnTriggerExit(Collider other)
    {



        if (other.tag == "joueur")
        {
            Debug.Log("coquillage");
            gameObject.GetComponent<AudioSource>().Stop();

        }

    }

}
