﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KroghHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       
    }

  


    public void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if(collision.gameObject.tag == "Fish")
        {
            print("fik fisk");
        }
    }

    void OnCollisionStay(Collision other)
    {

    }
}
