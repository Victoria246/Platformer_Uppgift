using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneToLoad = "SampleScene";

    // If the player collides with the object who has this script and has score which is greater than 
    // or equal to minimumScoreNeeded. Then it load the scene "sceneToLoad". 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            Coin.score = 0;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
