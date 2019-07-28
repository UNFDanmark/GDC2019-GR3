using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public float totalScore;
    public float TidTilbage;
    public Text DeathTime;
    //public Color color = (0, 0, 1, 1);

    private void Start()
    {
        
    }

    void Update()
    {
        TidTilbage -= Time.deltaTime;    

        scoretext.text = "Score:" + score;

        DeathTime.text = "Time:" + (int)TidTilbage;
        
        /*totalScore = totalScore + score;

        if(totalScore > 50 )
        {
           
        }*/

    }
}
