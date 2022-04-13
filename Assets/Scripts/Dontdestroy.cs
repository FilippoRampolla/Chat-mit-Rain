using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dontdestroy : MonoBehaviour
{
    //method for don't destroy object during the change of scene
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<Dontdestroy>().Length; i++)
        {
            if (Object.FindObjectsOfType<Dontdestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<Dontdestroy>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu"|| SceneManager.GetActiveScene().name == "Final")
        {
            Destroy(gameObject);
        }
    }
}
