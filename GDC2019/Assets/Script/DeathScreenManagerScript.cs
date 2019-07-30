﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathScreenManagerScript : MonoBehaviour
{
    public Text scoretext;

    void Start()
    {
        scoretext.text = "Score: " + Data_For_Winscreen.score;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            
            SceneManager.LoadScene("Project 1");
            
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {


            SceneManager.LoadScene("StartScreen");

        }
    }
}
