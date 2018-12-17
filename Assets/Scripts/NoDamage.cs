using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDamage : MonoBehaviour {

    public PlayerHealth playerHealth;

    //GetComponent to reference, access and manipulate a game object's component, in this case the PlayerHealth. 
    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    /*If the player enters the collider it would make the players health 
    "PlayerHealth" disabled/inaktive and would'nt be able to take any damage. (Isn't working :/)
    */
    void OnTriggerEnter2D(Collider2D col)

    {
        if (col.CompareTag(("Player")))
        {
            GetComponent<PlayerHealth>().enabled = false;
        }

    }
}
