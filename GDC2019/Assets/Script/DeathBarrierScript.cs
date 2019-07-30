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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fish")
        {
            
            
            Destroy(other.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
            
        }

        if (other.gameObject.tag == "Common_Fish")
        {
           
            Destroy(other.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
            
        }

        if (other.gameObject.tag == "Rare_Fish")
        {
            
            Destroy(other.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
            
        }

        if (other.gameObject.tag == "Epic_Fish")
        {
          
            Destroy(other.gameObject);
            NumberOfFish.GetComponent<FishSpawnerScript>().NumberOfFish--;
            
        }
    }
}
