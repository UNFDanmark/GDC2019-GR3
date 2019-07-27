using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfish : MonoBehaviour
{
    public Rigidbody Rb;
    public float movement = 10f;


    /* gør så fiskene ikke collider */
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Physics.IgnoreLayerCollision(8, 9);
        Physics.IgnoreLayerCollision(9, 9);
    }

    /* får fiskene til at bevæge sig */
    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.right * movement;
    }


    
}      