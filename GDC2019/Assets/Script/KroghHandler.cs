using System.Collections;
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
    public GameObject NumberOfFish;






    /* fjerner fisk når man rører dem og giver point*/
    private void Start()
    {
        NumberOfFish = GameObject.Find("FishSpawner");
    }

   


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fish")
        {
            if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
            {
                //Score.GetComponent<GameManagerScript>().score += 10;
                //Data_For_Winscreen.score += 10;
                other.gameObject.GetComponent<Testfish>().Catch();
                

            }

        }
        if (other.gameObject.tag == "Common_Fish")
        {
            if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
            {
                //Data_For_Winscreen.score += 20;
                other.gameObject.GetComponent<Testfish>().Catch();
             
                
            }

        }
        if (other.gameObject.tag == "Rare_Fish")
        {
            if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
            {
                //Data_For_Winscreen.score += 40;
                other.gameObject.GetComponent<Testfish>().Catch();
               
               
            }

        }
        if (other.gameObject.tag == "Epic_Fish")
        {
            if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
            {
                //Data_For_Winscreen.score += 80;
                other.gameObject.GetComponent<Testfish>().Catch();
               
                
            }

        }

    }
   
}
