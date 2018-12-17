using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    // Disables the sprite renderer, makes it invisable. 
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
