using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreapt : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("MainLevel");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Disable ()
    {
        gameObject.SetActive(false);
    }
}
