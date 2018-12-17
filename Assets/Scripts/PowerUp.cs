using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 2f;
    public SpriteRenderer rend;
    public float duration = 10f;
    public PlayerHealth player;
    private float spinSpeed = 180;

    //GetComponent to reference, access and manipulate a game object's component, in this case the PlayerHealth.
    //(Isnt working yet)
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    //The power up is constantly spinning/rotating 180 degrees and moves to the right, 
    //and due to the rotation the powerup goes back and forth.
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }

    /* When the player enter the collider, it picks up the powerup and starts the coroutine. 
    The function WaitForSeconds can only be used with a yield statement in coroutines.*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine (Pickup(other));
        }

    }
    /* First line says that when the powerup gets picked up, the players scale gets multiplied with 2.
     Then the player gets a random color but in a particular range of saturated and not-too-dark colors.
     Then the Sprite renderer and circle collider2d gets disabled so it can't generate more effect while the powerup's duration time.  
     Yield instruction to wait for a given number of seconds, 10s in this case, using scaled time
     When the time has passed the player gets back to it's original state regarding scale and color.
     At last, the object gets destroyed*/
    IEnumerator Pickup(Collider2D player)
    {
        player.transform.localScale *= multiplier;
        rend.color = Random.ColorHSV(0f, 1f, 0.5f, 1f, 1f, 1f);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(10);
        rend.color = new Color(1f, 1f, 1f);
        player.transform.localScale /= multiplier;
        Destroy(gameObject);
    }


   

}
