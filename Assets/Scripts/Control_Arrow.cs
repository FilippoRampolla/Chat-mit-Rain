using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Arrow : MonoBehaviour
{

    
    //destroy the arrow for continue when you don't need more
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex > 13 && SceneManager.GetActiveScene().buildIndex < 20)
        {
            Destroy(this.gameObject);
        }
        
    }

    public void Tutorial()
    {
        FindObjectOfType<AudioManager>().Play("click");
        if (SceneManager.GetActiveScene().name== "Intermezzo")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Intermezzo 1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Intermezzo 2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Intermezzo 3")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Story")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Story 1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
