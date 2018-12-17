using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Static innebär att variabeln är samma för alla, om man ändrar en ändrar man alla med samma script.
    //Static variable can be used to refer all objects, and are more associated with classes rather than objects.
    public static int score;

    public int amount = 1;

    private float spinSpeed = 180;

    //The Coin is constantly spinning/rotating 180 degrees in the y-axis. 
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    // If the coins collider collide with the player then the score get added to the amount. 
    // If they collide the coin also get destroyed. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Coin.score += amount;
            Destroy(gameObject);
        }
    }
}
