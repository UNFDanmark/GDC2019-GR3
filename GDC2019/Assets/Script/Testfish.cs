using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfish : MonoBehaviour
{
    public Rigidbody Rb;
    public float movement = 10f;
    public bool Catched = false;
    public float force = 100;
  


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
       
        if (Catched == false)
        {
            gameObject.GetComponent<Rigidbody>().velocity = transform.right * movement;
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Quaternion.Euler(0, 0, 180);

            //Rb.AddForce(transform.forward * force);
        }
       
    }
    public void Catch()
    {
        Catched = true;
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