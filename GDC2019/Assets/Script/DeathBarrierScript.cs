using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrierScript : MonoBehaviour
{
    /* fjerner fisk*/
    public void OnCollisionEnter(Collision Wall)
    {

        if (Wall.gameObject.tag == "Fish")
            Destroy(Wall.gameObject);

        if (Wall.gameObject.tag == "Common_Fish")
            Destroy(Wall.gameObject);

        if (Wall.gameObject.tag == "Rare_Fish")
            Destroy(Wall.gameObject);

        if (Wall.gameObject.tag == "Epic_Fish")
            Destroy(Wall.gameObject);


    }



}
