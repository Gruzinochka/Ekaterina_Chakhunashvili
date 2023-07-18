using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScreapt : MonoBehaviour
{
    public float Seconds;
    public float Minute;
    public Text Timer;
    public float maxTime;
    public float maxTim;


    public void Update()
    {
        maxTim += Time.deltaTime;
        maxTime = Mathf.Round(maxTim*3);
        Timer.text =  Mathf.Round(maxTim*3).ToString();
    }


    // public void Start()
    // {
    //     maxTime = PlayerPrefs.GetInt("R3");
    // }
    //
    //
    // public void Update()
    // {
    //     if (maxTime<(Minute*60+Seconds))
    //     {
    //         maxTime = Convert.ToInt32(Minute * 60 + Seconds);
    //         Max();
    //     }
    //     if (Minute<10)
    //     {
    //         if (Seconds>=10)
    //         {
    //             Timer.text = "0" + Minute.ToString() + ":" + Mathf.Round(Seconds).ToString();
    //         }
    //         else
    //         {
    //             Timer.text = "0" + Minute.ToString() + ":" + "0"+  Mathf.Round(Seconds).ToString();
    //
    //         }
    //     }
    //     else
    //     {
    //         if (Seconds>=10)
    //         {
    //             Timer.text =Minute.ToString() + ":" + Mathf.Round(Seconds).ToString();
    //         }
    //         else
    //         {
    //             Timer.text =Minute.ToString() + ":" + "0"+  Mathf.Round(Seconds).ToString();
    //
    //         }
    //     }
    //     Seconds += Time.deltaTime;
    //     if (Seconds>=59)
    //     {
    //         Minute++;
    //         Seconds = 0;
    //     }
    // }
    //
    public void Max()
    {
        PlayerPrefs.SetFloat("NewMax",maxTime);
    }

    public void MenuScene()
    {
        Max();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
