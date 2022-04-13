using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    // reference for the answers
    public GameObject first, second, third ,fourth;
    //reference for the question
    public GameObject question;
    //time of the finish of the video
    public float endVideo = 3f;
    //reference for the levelLoader
    public GameObject leveloader;
    //reference to the slider
    public GameObject slider;

    //start the appearance of the question
    public void Start()
    {
        StartCoroutine(Question());
    }
    //find the reference to the background
    private void Update()
    {
        slider = GameObject.Find("blackback");
    }
    //delay for wait the end of the video
    IEnumerator Question()
    {
        yield return new WaitForSeconds(endVideo);
        ActiveUI();
    }
    //active the UI for question and answer
    public void ActiveUI()
    {

        question.SetActive(true);
        first.SetActive(true);
        second.SetActive(true);
        third.SetActive(true);
        if(SceneManager.GetActiveScene().name== "Sentence1" || SceneManager.GetActiveScene().name == "Sentence2")
        {
            fourth.SetActive(true);
        }
    }

    //correct aswer
    public void Correct()
    {
        FindObjectOfType<AudioManager>().Play("correct");
        leveloader.GetComponent<GoToHome>().Gotonextlevel();
        slider.GetComponent<ProgressBar>().UpdateProgress();
    }

    //wrong answer
    public void Wrong()
    {
        FindObjectOfType<AudioManager>().Play("wrong");
        Debug.Log("wronganswer");
    }
}
