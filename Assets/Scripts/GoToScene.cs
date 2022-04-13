using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    /* function that permit to load the first challenge  */
    public void GoToHouse()
    {
        SceneManager.LoadScene("Intermezzo");
    }
}
