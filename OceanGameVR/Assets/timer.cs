using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject time;
    public GameObject fin;

    private IEnumerator Reussite()
    {
        time.SetActive(true);
        yield return new WaitForSeconds(120f);
        fin.SetActive(true);
        yield break;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
