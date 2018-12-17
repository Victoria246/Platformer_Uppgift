using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public Animator animator;
    public SpriteRenderer rend;

    /* When the player enter or stay inside the collider, the IsShooting animation will activate and change the color of the Enemy to red.  
     If the player is out of range or is not colliding with the collider then the IsShooting animation gets disabled and goes back to it's original color. */

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == ("Player"))
        {
            animator.SetBool("IsShooting", true);
            rend.color = new Color(1f, 0.3f, 0.3f);
        }
        if (col.tag != ("Player"))
        {
            animator.SetBool("IsShooting", false);
            rend.color = new Color(1f, 1f, 1f);
        }
    }

}
