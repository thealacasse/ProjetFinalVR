using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    //public GameObject time;
    public GameObject fin;

   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Reussite2");
    }

    IEnumerator Reussite2()
    {
        //time.SetActive(true);
        yield return new WaitForSeconds(120f);
        fin.SetActive(true);
        yield break;
    }

   
}
