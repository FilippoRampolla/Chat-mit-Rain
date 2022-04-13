using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
   
    //set the progress of 0
    public float progress = 0;
    //reference to the slider
    public Slider slider;
    //reference to the transition
    public GameObject leveloader;

    //find the levelloader
    private void Update()
    {
        leveloader = GameObject.Find("LeveLoader");
    }

    //function that upgrade the value of the progress bar
    public void UpdateProgress()
    {
        progress=progress+7.14f;
        slider.value = progress;
        leveloader.GetComponent<GoToHome>().Gotonextlevel();


    }

}
