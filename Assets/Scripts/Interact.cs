using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Interact : MonoBehaviour
{

    //reference for the levelLoader
    public GameObject leveloader;

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("theme");
    }
    // Update is called once per frame
    void Update()
    {
        //Click everywhere to go on
        if (Input.GetMouseButtonDown(0))
        {

            if (SceneManager.GetActiveScene().name == "Firstpage")
            {
                leveloader.GetComponent<GoToHome>().Gotonextlevel();
                FindObjectOfType<AudioManager>().Play("click");
            }
            if (SceneManager.GetActiveScene().name == "Final")
            {
                SceneManager.LoadScene("Firstpage");
                FindObjectOfType<AudioManager>().Play("click");
            }
        }
    }
}
