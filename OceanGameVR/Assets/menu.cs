using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu;
    public GameObject instruction;
    public GameObject Choix;
    public GameObject requin;
    public GameObject peinguin;
    public GameObject hamster;



    public void commencer()
    {
        Menu.SetActive(false);
        instruction.SetActive(true);
    }
    public void suivant()
    {
        Choix.SetActive(true);
        instruction.SetActive(false);
    }
    public void requins()
    {
        Choix.SetActive(true);
        SceneManager.LoadScene("requinguingue");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
