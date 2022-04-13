using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GoToHome : MonoBehaviour
{
    /* Reference for the Ui for exit and go to the menu  */
    public GameObject Ui_check;
    /* Reference for the blur background  */
    public GameObject Blur;
    /* Reference for the Video */
    public VideoPlayer Video;
    //reference to our animator of the crossfase object
    public Animator transition;

    /* function that Load the menu Scene  */
    public void GoToMenu()
    {
        FindObjectOfType<AudioManager>().Play("click");
        StartCoroutine(Loadlevel("Menu"));
    }
    /* function that Load the next Scene  */
    public void Gotonextlevel()
    {
        FindObjectOfType<AudioManager>().Play("click");
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex+1));
    }
    /* function open the Ui to exit  */
    public void OpenCheck()
    {
        Ui_check.SetActive(true);
        Blur.SetActive(true);
        /* Stop the video in the background  */
        Video.Pause();
    }

    /* function close the Ui to exit  */
    public void CloseCheck()
    {
        Ui_check.SetActive(false);
        Blur.SetActive(false);
        
    }
    //Load the scene with the crossfade transition
    IEnumerator Loadlevel(string levelname)
    {
        //play the animation
        transition.SetTrigger("Start");
        //wait time
        yield return new WaitForSeconds(1);
        //Load the scene
        SceneManager.LoadScene(levelname);

    }
    IEnumerator Loadlevel(int levelindex)
    {
        //play the animation
        transition.SetTrigger("Start");
        //wait time
        yield return new WaitForSeconds(1);
        //Load the scene
        SceneManager.LoadScene(levelindex);

    }
}
