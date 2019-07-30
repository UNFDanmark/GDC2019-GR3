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
    public GameObject GM;
    public bool IsShot = false;
    public Material DødMaterial;
    public AudioClip Yeet_Sound;


    /* gør så fiskene ikke collider */
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Physics.IgnoreLayerCollision(8, 9);
        Physics.IgnoreLayerCollision(9, 9);
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

                //Yeet_force lyd
                AudioSource.PlayClipAtPoint(Yeet_Sound, gameObject.transform.position,1f);

                
                tilføjet_yeet = true;

            }

        }
    }
    public void Catch()
    {
        Catched = true;
    }
    
    
}