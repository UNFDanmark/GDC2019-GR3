using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public float totalScore;
    public float TidTilbage;
    public Text TotalTime;
    public float totTid;
    public Text DeathTime;
    public GameObject DeathScreen;
   

    private void Start()
    {

      
    }

    void Update()
    {
        TidTilbage -= Time.deltaTime;    

        scoretext.text = "Score:" + score;

        DeathTime.text = "Time:" + (int)TidTilbage;

        TotalTime.text = "TAOT: " + (int)Time.time;
        
        if (TidTilbage <= 0)
        {
            SceneManager.LoadScene("DEATHSCREEN!");
        }
        
        

    }
}
