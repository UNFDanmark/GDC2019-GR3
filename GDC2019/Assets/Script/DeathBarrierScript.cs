using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrierScript : MonoBehaviour

    
{
    public GameObject NumberOfFish;

    public void Start()
    {
        NumberOfFish = GameObject.Find("FishSpawner");
    }

    /* fjerner fisk og minuser numberOfFisk*/
    public void OnCollisionEnter(Collision Wall)
    {

        if (Wall.gameObject.tag == "Fish")
        {


            Destroy(Wall.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
        }

        if (Wall.gameObject.tag == "Common_Fish")
        {
            Destroy(Wall.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
        }

        if (Wall.gameObject.tag == "Rare_Fish")
        {
            Destroy(Wall.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
        }

        if (Wall.gameObject.tag == "Epic_Fish")
        {
            Destroy(Wall.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
        }
    }



}
