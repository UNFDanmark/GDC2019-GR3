﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KroghHandler : MonoBehaviour
{
    public GameObject Score;

    //Pointene for hver slags fisk
    public int TestfishPoint;
    public int Common_Fishpoint;
    public int Rare_Fishpoint;
    public int Epic_Fishpoint;
    public int NumberOfFish2;





  

    /* fjerner fisk når man rører dem og giver point*/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fish")
        {
            Score.GetComponent<GameManagerScript>().score += 10;
            Destroy(other.gameObject);
            

        }
        if (other.gameObject.tag == "Common_Fish")
        {
            Score.GetComponent<GameManagerScript>().score += 20;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Rare_Fish")
        {
            Score.GetComponent<GameManagerScript>().score += 40;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Epic_Fish")
        {
            Score.GetComponent<GameManagerScript>().score += 80;
            Destroy(other.gameObject);
        }

    }
}
