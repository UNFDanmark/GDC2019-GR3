﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{   //Variabler for vores værdier//
    public float speed = 50f;
    public Rigidbody RB;
    public GameObject GM;
    public GameObject Fish_Spawner;
    public bool tilføjet_yeet = false;
   



    void Start()
    {
        
        //Identitet for Rigitbody ting tang//
        RB = GetComponent<Rigidbody>();
        GM = GameObject.Find("Game manager");
        Fish_Spawner = GameObject.Find("FishSpawner");
        tilføjet_yeet = GameObject.Find("Testfish");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray Mouse_position = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Mouse_position, out hit))
            {
                if(hit.transform.gameObject.layer == 9 && tilføjet_yeet == false)
                {
                    hit.transform.gameObject.GetComponent<Testfish>().IsShot = true;
                    Material dødFiskMaterial = hit.transform.gameObject.GetComponent<Testfish>().DødMaterial;
                    print(dødFiskMaterial);
                    hit.transform.GetChild(0).GetComponent<Renderer>().material= dødFiskMaterial;
                    hit.transform.gameObject.GetComponent<Rigidbody>().AddForce(0, 10, 0, ForceMode.Impulse);


                }
                

            }


        }
    }


    void FixedUpdate()
    {
        //Måden spilleren bevæger sig//
        float HSpeed = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector3(HSpeed * speed, RB.velocity.y, RB.velocity.z);

        float VSpeed = Input.GetAxisRaw("Vertical");
        RB.velocity = new Vector3(RB.velocity.x, VSpeed * speed, RB.velocity.z);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 12.3f, 48.5f), transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.GetComponent<Rigidbody>().velocity.y <= 0 && other.transform.gameObject.GetComponent<Testfish>().IsShot)
        {
            if (other.transform.tag == "Fish") //tid fået for at fange fisk
            {
                //GM.GetComponent<GameManagerScript>().TidTilbage += 0.75f;
                Fish_Spawner.GetComponent<FishSpawnerScript>().NumberOfFish--;
                Data_For_Winscreen.score += 50;
                Destroy(other.transform.gameObject);
            }

            if (other.transform.tag == "Common_Fish") //tid fået for at fange fisk
            {
                //GM.GetComponent<GameManagerScript>().TidTilbage += 1.25f;
                Fish_Spawner.GetComponent<FishSpawnerScript>().NumberOfFish--;
                Data_For_Winscreen.score += 200;
                Destroy(other.transform.gameObject);
            }

            if (other.transform.tag == "Rare_Fish") //tid fået for at fange fisk
            {
                //GM.GetComponent<GameManagerScript>().TidTilbage += 1.75f;
                Fish_Spawner.GetComponent<FishSpawnerScript>().NumberOfFish--;
                Data_For_Winscreen.score += 400;
                Destroy(other.transform.gameObject);
            }

            if (other.transform.tag == "Epic_Fish") //tid fået for at fange fisk
            {
                //GM.GetComponent<GameManagerScript>().TidTilbage += 2.5f;
                Fish_Spawner.GetComponent<FishSpawnerScript>().NumberOfFish--;
                Data_For_Winscreen.score += 900;
                Destroy(other.transform.gameObject);
            }
        }
    }
}