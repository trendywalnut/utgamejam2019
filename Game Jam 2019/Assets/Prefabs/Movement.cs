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

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
        jump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody.velocity = new Vector2(-mySpeed, myRigidBody.velocity.y);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            myRigidBody.velocity = new Vector2(mySpeed, myRigidBody.velocity.y);
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && jump) {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, myJumpForce);
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = true;
    }
}
