using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{   //Variabler for vores værdier//
    public float speed = 50f;
    public Rigidbody RB;
    public float HookRadius;


    
    void Start()
    {
        
        //Identitet for Rigitbody ting tang//
        RB = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        //Måden spilleren bevæger sig//
        float HSpeed = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector3(HSpeed * speed, RB.velocity.y, RB.velocity.z);

        float VSpeed = Input.GetAxisRaw("Vertical");
        RB.velocity = new Vector3(RB.velocity.x, VSpeed * speed, RB.velocity.z);

  

    }
    
    
}