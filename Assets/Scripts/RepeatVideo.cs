using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class RepeatVideo : MonoBehaviour
{
    /* Reference for the video  */
    public VideoPlayer Video;
    //flag variable
    private int f;
    //reference to exlamation Mark
    public GameObject exlamation;

    private void Start()
    {
        f = 0;
    }

    /* Function call by the button to repeat the video  */
    public void Repeat()
    {
        FindObjectOfType<AudioManager>().Play("click");
        Video.Stop();
        Video.Play();
    }
    public void Play()
    {
        FindObjectOfType<AudioManager>().Play("click");
        Video.Play();
    }
    public void Pause()
    {
        FindObjectOfType<AudioManager>().Play("click");
        Video.Pause();
        
    }
    //Manage the notification
    private void Update()
    {
        if (!Video.isPlaying)
        {
            f++;
        }
        if (!Video.isPlaying)
        {
            if (SceneManager.GetActiveScene().name == "Home_Ich"|| SceneManager.GetActiveScene().name == "Sentence1")
            {
                if (f == 1)
                {
                    exlamation.SetActive(true);
                }
            }
        }
    }
}
