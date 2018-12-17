using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToDestroy : MonoBehaviour
{
    public GameObject objectToDestroy;

    // if the Ice collider collide with the object tagged with "Player" then the Ice object gets destroyed. 
    // if the Ice collider collide with the object tagged with "DestroyObject" then the Ice object gets destroyed. 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Player"))
        {
            Destroy(objectToDestroy);
        }
        else if (col.tag == ("DestroyObject"))
        {
            Destroy(objectToDestroy);
        }
      
        
    }

}
