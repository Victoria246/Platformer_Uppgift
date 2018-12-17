using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    public GroundChecker groundCheck;
    public Animator animator;

    private Rigidbody2D rbody;

    //GetComponent to reference, access and manipulate a game object's component, in this case the Rigidbody2D of the player. 
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    /* The ridgidbodys velocity is controlled by two values, x and y. 
     X is "Input.GetAxisRaw("Horizontal")" which means the horizontal axis is by default mapped to the arrow keys.
     Y is "rbody.velocity.y" which is linear velocity of the ridgidbody in Y. 
     Animator, the aniamtions name is speed. rbody.velocity is refering to it's velocity vector in world space and magnitude it's length
     Animator, the animations name is Isjumping. Then the bool value is depending on the isGrounded function(?).                 */
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        animator.SetFloat("Speed", rbody.velocity.magnitude);
        animator.SetBool("IsJumping", !groundCheck.isGrounded);

        // If the button for jump is pressed and if isgrounded is true then the player can jump, which means it can't jump if it's in the air.
        // y is "jumpSpeed", which means jump up with the speed of the float "jumpSpeed".  
        if (Input.GetButtonDown("Jump"))
        {
            if (groundCheck.isGrounded == true)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }

        }

       
    }

}
