using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int curHealth = 5;
    public int maxHealth = 5;
    public string sceneToLoad = "SampleScene";
    public PlayerHealth playerHealth;

    // The game always starts with maxHealth.
    void Start ()
    {
        curHealth = maxHealth;
	}

    /* if the player's current health is less then 0 it is equal to 0 and not a negative number. 
       calls the die function, which is the code for loading a new or same scene, its optional 
       since sceneToLoad is a public string and can therefore be changed. */
    void Update ()
    {
        if (curHealth <= 0)
        {
            curHealth = 0;
            die();
        }
	}

    void die()

    {
        SceneManager.LoadScene(sceneToLoad);
    }

    // if the players collider collides with an enemy then the current health get one life less. 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Enemy"))

        {
            playerHealth.curHealth = curHealth - 1;
        }

    }

}
