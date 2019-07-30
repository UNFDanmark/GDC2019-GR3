using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{   //Variabler for vores værdier//
    public float speed = 50f;
    public Rigidbody RB;
    public GameObject GM;
    public GameObject Fish_Spawner;
    public bool tilføjet_yeet = false;
    public AudioClip Gun_Sound;
    public float Yeet_Tid_Tilbage;
    public float Yeet_Tid_Max;
    public GameObject Character_Idle;
    public GameObject Character_Yeet;



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
            AudioSource.PlayClipAtPoint(Gun_Sound, gameObject.transform.position, 100f);
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
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 20f, 72f), transform.position.z);
        if (Yeet_Tid_Tilbage <= 0)
        {
            Character_Idle.SetActive(true);
            Character_Yeet.SetActive(false);
        }
        else
        {
            Yeet_Tid_Tilbage -= Time.fixedDeltaTime;
        }
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
    public void Yeet_Er_Nemt()
    {
        Character_Idle.SetActive(false);
        Character_Yeet.SetActive(true);
        Yeet_Tid_Tilbage = Yeet_Tid_Max;
    }
}