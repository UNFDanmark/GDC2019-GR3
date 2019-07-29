using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfish : MonoBehaviour
{
    public Rigidbody Rb;
    public float movement = 10f;
    public bool Catched = false;
    public float Yeet_force = 1;
    public float Min_random;
    public float Max_random;
    public bool tilføjet_yeet = false;
    public GameObject NumberOfFish;
    public GameObject GM;


    /* gør så fiskene ikke collider */
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Physics.IgnoreLayerCollision(8, 9);
        Physics.IgnoreLayerCollision(9, 9);
        NumberOfFish = GameObject.Find("FishSpawner");
        GM = GameObject.Find("Game manager");

    }

    /* får fiskene til at bevæge sig */
    private void FixedUpdate()
    {
       
        if (Catched == false)
        {
            gameObject.GetComponent<Rigidbody>().velocity = transform.right * movement;
        }
        else
        {
            

            if (tilføjet_yeet == false)
            {
                //stop
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

                //drej
                transform.eulerAngles = new Vector3(0, 0, 90);

                //giver fisken gravity
                gameObject.GetComponent<Rigidbody>().useGravity = true;

                //skub
                gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(Min_random, Max_random), Yeet_force, 0, ForceMode.Impulse);

                tilføjet_yeet = true;

               

            }


            

            //Rb.AddForce(transform.forward * force);
        }
       
    }
    public void Catch()
    {
        Catched = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Rigidbody>().velocity.y <= 0 && other.gameObject.tag == "Fisker")
        {

            if (other.gameObject.tag == "Fish") //tid for lyserød fisk
            {
                if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
                {
                    GM.GetComponent<GameManagerScript>().TidTilbage += 10;
                    Destroy(gameObject);
                }
            }

            if (other.gameObject.tag == "Common_Fish") //tid for lyserød fisk
            {
                if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
                {
                    GM.GetComponent<GameManagerScript>().TidTilbage += 10;
                    Destroy(gameObject);
                }
            }

            if (other.gameObject.tag == "Rare_Fish") //tid for lyserød fisk
            {
                if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
                {
                    GM.GetComponent<GameManagerScript>().TidTilbage += 10;
                    Destroy(gameObject);
                }
            }

            if (other.gameObject.tag == "Epic_Fish") //tid for lyserød fisk
            {
                if (other.gameObject.GetComponent<Testfish>().tilføjet_yeet == false)
                {
                    GM.GetComponent<GameManagerScript>().TidTilbage += 10;
                    Destroy(gameObject);
                }
            }



            GM.GetComponent<GameManagerScript>().TidTilbage += 10;
            Destroy(gameObject);
        }
    }






    /*
    if(fisk == lille)
    {
    //gør ikke noget
    }
    else if(fisk == mellem)
    {
    //fang fisk i næt
    }

    */

}