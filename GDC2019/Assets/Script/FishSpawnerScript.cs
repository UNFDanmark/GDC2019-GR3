using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnerScript : MonoBehaviour
{
    public GameObject fish, fish_common, fish_rare, fish_epic;
    public GameObject[] Fisk = new GameObject[3];
    public int placement;
    public int rotation = 180;
    public float tidMellemSpawns;
    public float tidTilSpawn;
    public int NumberOfFish;
    public int NumberOfFishSpawning;
    public GameObject spawned_fish;


    /* timer der viser hvornår fisk spawner*/
    private void Start()
    {
        tidTilSpawn = 0;
    }
    void FixedUpdate()
    {
        if (NumberOfFish < 5)
        {
            tidTilSpawn = 0;
        }


        if (tidTilSpawn <= 0)
        {
            SpawnFish();
            tidTilSpawn = tidMellemSpawns;
        }
        else
        {
            tidTilSpawn -= Time.deltaTime;
        }

        
    }





    /* vælger hvor fisk skal spawne */
    public void SpawnFish()
    {
        //int placement = Random.Range(0, 2);
        

        int NumberOfFishSpawning = Random.Range(0, 4);
        print(placement);

        if (NumberOfFishSpawning == 0)
        {

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);
        }
        if (NumberOfFishSpawning == 1)
        {
            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);
        }
        if (NumberOfFishSpawning == 2)
        {
            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);
        }
        if (NumberOfFishSpawning == 3)
        {
            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

        }


        if (NumberOfFishSpawning == 0)
        {

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

        }
        if (NumberOfFishSpawning == 1)
        {
            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);
        }
        if (NumberOfFishSpawning == 2)
        {

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

        }
        if (NumberOfFishSpawning == 3)
        {

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

            GetFish();
            NumberOfFish = NumberOfFish + 1;
            //print(NumberOfFish);

        }
    }

    /* vælg hvilken fisk det er */
    public void GetFish()
    {
        int tal = Random.Range(1, 100);
        int placement = Random.Range(0, 2);


        if (0 <= tal && tal <= 50)
        {
            if (placement == 1)
            {
                int x = Random.Range(85, 145);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[0], new Vector3(x, y, 26), Quaternion.Euler(180, 0, 180));
            }
            else if(placement == 0)
            {
                int x = Random.Range(-150, -90);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[0], new Vector3(x, y, 26), Quaternion.identity);
            }
        }
        if (51 <= tal && tal <= 75)
        {
            if (placement == 1)
            {
                int x = Random.Range(85, 145);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[1], new Vector3(x, y, 26), Quaternion.Euler(180, 0, 180));
            }
            else if (placement == 0)
            {
                int x = Random.Range(-150, -90);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[1], new Vector3(x, y, 26), Quaternion.identity);
            }
        }
        if (76 <= tal && tal <= 90)
        {
            if (placement == 1)
            {
                int x = Random.Range(85, 145);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[2], new Vector3(x, y, 26), Quaternion.Euler(180, 0, 180));
            }
            else if (placement == 0)
            {
                int x = Random.Range(-150, -90);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[2], new Vector3(x, y, 26), Quaternion.identity);
            }
        }
        if (91 <= tal && tal <= 100)
        {
            if(placement == 1)
            {
                int x = Random.Range(85, 145);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[3], new Vector3(x, y, 26), Quaternion.Euler(180, 0, 180));
            }
            else if (placement == 0)
            {
                int x = Random.Range(-150, -90);
                int y = Random.Range(-30, 10);
                Instantiate(Fisk[3], new Vector3(x, y, 26), Quaternion.identity);
            }
        }
        
    }
} 

