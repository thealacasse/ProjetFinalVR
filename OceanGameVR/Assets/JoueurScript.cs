using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource Cristaux;


    private void OnTriggerEnter(Collider other)
    {



    /*  if (other.tag == "zone1")
       {
          Debug.Log("coquillage");
            Cristaux.Play();
        
     }
        else
        {
            Cristaux.Pause();
        }*/
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
