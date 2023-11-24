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



    public void commencer()
    {
        Menu.SetActive(false);
        instruction.SetActive(true);
    }
    public void jouer()
    {
        SceneManager.LoadScene("animation_1");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
