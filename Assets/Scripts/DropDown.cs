using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject leveloader;
    public int f = 0;
    public GameObject next;

    //Functions for manage the solution of the dropdown menu (the first correct)
    public void HandleInputData1(int val)
    {
        if(val == 1)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f++;
            Debug.Log("correctganswer");
        }
        if (val == 2)
        {
            FindObjectOfType<AudioManager>().Play("click");
            Debug.Log("wronganswer");
        }
        if (val == 3)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f--;
            Debug.Log("wronganswer");
        }
    }
    //Functions for manage the solution of the dropdown menu (the second correct)
    public void HandleInputData2(int val)
    {
        if (val == 1)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f--;
            Debug.Log("wronganswer");
        }
        if (val == 2)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f++;
            Debug.Log("correctganswer");
        }
        if (val == 3)
        {
            FindObjectOfType<AudioManager>().Play("click");
            Debug.Log("wronganswer");
        }
    }
    //Functions for manage the solution of the dropdown menu (the third correct)
    public void HandleInputData3(int val)
    {
        if (val == 1)
        {
            FindObjectOfType<AudioManager>().Play("click");
            Debug.Log("wronganswer");
        }
        if (val == 2)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f--;
            Debug.Log("wronganswer");
        }
        if (val == 3)
        {
            FindObjectOfType<AudioManager>().Play("click");
            f++;
            Debug.Log("correctganswer");
        }
    }

    //Functions for manage the final solution in accord to the other 3
    public void HandleInputDataFinal(int val)
    {
        if (val == 1)
        {
            FindObjectOfType<AudioManager>().Play("click");
            if (f >= 3) 
            {
                next.SetActive(true);
            }

            
        }
        if (val == 2)
        {
            FindObjectOfType<AudioManager>().Play("click");
            Debug.Log("wronganswer");
        }
        if (val == 3)
        {
            FindObjectOfType<AudioManager>().Play("click");
            Debug.Log("wronganswer");
        }
    }
}
