﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public string startSceneName;


    public void StartPressed()
    {
        SceneManager.LoadScene(startSceneName);
      
    
    
    }

    public void CloseGame()
    {
        Application.Quit();


    }

    
    
}
