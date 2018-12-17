using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // GetComponent to reference, access and manipulate a game object's component, in this case the TextMeshProUGUI.
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // When the score updates then so does the text
    //By calling a formatting method to convert a value or object to its string representation.
    void Update()
    {
        text.text = string.Format("Score: {0:0000}", Coin.score);
    }
}
