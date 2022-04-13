using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Showtips : MonoBehaviour
{
    /* Reference for the tiplist  */
    public GameObject Tipslist;
    /* Reference fo the video  */
    public VideoPlayer video;
    private int i;
    //reference to exlamation Mark and to the text
    public GameObject exlamation, attention;

    private void Start()
    {
        /* always start the flag to 0  */
        i = 0;
    }

    /* function that permit to show and hide the learn list  */
    public void Showtipslist()
    {
        if (i == 0)
        {
            if (exlamation.active)
            {
                FindObjectOfType<AudioManager>().Play("click");
                attention.SetActive(true);
                exlamation.SetActive(false);
            }
            video.Pause();
            Tipslist.SetActive(true);
            i++;
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("click");
            Tipslist.SetActive(false);
            i--;
            
        }
        
    }
}
