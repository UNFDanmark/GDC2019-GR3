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


    /* timer der viser hvornår fisk spawner*/
    private void Start()
    {
        tidTilSpawn = 0;
    }
    void FixedUpdate()
    {
        if(tidTilSpawn < 0)
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
        int placement = Random.Range(0, 2);
        //print(placement);

        if (placement == 0)
        {

            int x = Random.Range(-150, -90);
            int y = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x, y, 26), transform.rotation);
            NumberOfFish = NumberOfFish + 1;
            print(NumberOfFish);

            int x1 = Random.Range(-150, -90);
            int y1 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x1, y1, 26), transform.rotation);
            NumberOfFish += 1;
            print(NumberOfFish);

            int x2 = Random.Range(-150, -90);
            int y2 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x2, y2, 26), transform.rotation);
            NumberOfFish += 1;
            print(NumberOfFish);

            int x3 = Random.Range(-150, -90);
            int y3 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x3, y3, 26), transform.rotation);
            NumberOfFish += 1;
            print(NumberOfFish);
        }
        if (placement == 1)
        {

            int x4 = Random.Range(85, 145);
            int y4 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x4, y4, 26), Quaternion.Euler(0, 0, 180));
            NumberOfFish += 1;
            print(NumberOfFish);

            int x5 = Random.Range(85, 145);
            int y5 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x5, y5, 26), Quaternion.Euler(0, 0, 180));
            NumberOfFish += 1;
            print(NumberOfFish);

            int x6 = Random.Range(85, 145);
            int y6 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x6, y6, 26), Quaternion.Euler(0, 0, 180));
            NumberOfFish += 1;
            print(NumberOfFish);

            int x7 = Random.Range(85, 145);
            int y7 = Random.Range(-30, 10);
            Instantiate(GetFish(), new Vector3(x7, y7, 26), Quaternion.Euler(0, 0, 180));
            NumberOfFish += 1;
            print(NumberOfFish);
        }
    }

    /* vælg hvilken fisk det er */
    public GameObject GetFish()
    {
        int tal = Random.Range(1, 100);
        //print(tal);

        if (0 < tal && tal < 50)
        {
            return Fisk[0];
        }
        if (51 < tal && tal < 75)
        {
            return Fisk[1];
        }
        if (76 < tal && tal < 90)
        {
            return Fisk[2];
        }
        if (91 < tal && tal < 100)
        {
            return Fisk[3];
        }
        return Fisk[0];
    }
} 

