using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded;

    // If the Player collide with the ground then isGrounded is true. 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    // If the player continuous to be grounded then isGrounded is true, is essential to stop a bug that made the player jump spontaneously.  
    public void OnTriggerStay2D(Collider2D collision)
    {
        isGrounded = true;
    }

    // If the Player Isn't colliding with the ground, then isGrounded is false.
    public void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
