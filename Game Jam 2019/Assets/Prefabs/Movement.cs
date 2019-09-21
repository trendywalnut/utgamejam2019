using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float mySpeed;
    public float myJumpForce;
    private bool jump;
    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;
    private SpriteRenderer mySpriteRenderer;
    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myAnimator = GetComponent<Animator>();
        jump = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if moving left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //makes sprite face the right direction and plays animation
            mySpriteRenderer.flipX = false;
            myRigidBody.velocity = new Vector2(-mySpeed, myRigidBody.velocity.y);
            if(jump)
            {
                myAnimator.Play("PlayerRun");
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //makes sprite face the right direction and plays animation
            mySpriteRenderer.flipX = true;
            myRigidBody.velocity = new Vector2(mySpeed, myRigidBody.velocity.y);
            if (jump)
            {
                myAnimator.Play("PlayerRun");
            }
        }
        else
        {
            if(jump)
            {
                myAnimator.Play("PlayerIdle");
            }
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && jump)
        {
            myAnimator.Play("PlayerJump3");
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, myJumpForce);
            jump = false;
        }
        
    }

    //after collision allows alien to jump again
    private void OnCollisionEnter2D(Collision2D collision)
    {
        myAnimator.Play("PlayerIdle");
        jump = true;
    }
}
