using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeHearts : MonoBehaviour
{
    public Sprite[] HeartsSprites;
    public Image HeartUI;
    public PlayerHealth player;



    // GetComponent to reference, access and manipulate a game object's component, in this case the PlayerHealth of the Player.
    // (Script isnt woriking yet)
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
	

	// The heart sprites change depanding of the players current health. 
	void  Update ()
    {
        HeartUI.sprite = HeartsSprites[player.curHealth];
    }
}
