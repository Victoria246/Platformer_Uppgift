using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    // GetComponent to reference, access and manipulate a game object's component, in this case the Rigidbody2D of the Enemy.
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    /* An if-statement which implicates that when the statement inside the brackets is true then the enemy walks forward.
       The line that refers to the scale causes the enemy to not go backwards.*/
    private void FixedUpdate()
    {
        if (left == true)
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-0.35f, 0.3f, 1);
        }
        else
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(0.35f, 0.3f, 1);
        }
    }

    /* If the enemy collide with the collider called "InvisebleWall", which is located at two turning points
     then the robot switches direction and the entire sprite rotates 180 degrees. The reason I didn't use left = !left is because 
     it would not flip the vertical arrow axis, which could make it harder to program the shooting script. 
     (svårt att förklara hur jag menar, kan ta det muntligt om det behövs förtydligande.)  */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            //left = !left;
            transform.Rotate(0f, 180f, 0);
        }
    }
}
