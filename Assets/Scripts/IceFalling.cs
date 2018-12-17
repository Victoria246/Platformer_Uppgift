using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFalling : MonoBehaviour
{
    Rigidbody2D rb;

    /*GetComponent is the primary way of accessing other components. 
     Is accessible for both built in components or scripts with this function.
     In this case, it refers to the ice's rigidbody*/
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}

    /*If an object with Player tags enters the collider the ridgidbody 
     of this object will go from kinematic to dynamic which results in gravity */
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Player"))
        {
            rb.isKinematic = false;        
        }
    }
    

}
