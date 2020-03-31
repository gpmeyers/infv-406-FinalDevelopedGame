using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public Rigidbody rb;

    public Transform player;

    public float forwardForce = 1000f;
    public float sidewardForce = 600f;
    public float jumpForce = 2000f;
    private bool onGround = true;

    // We are using Fixed Update because we are using this for player physics.
    void FixedUpdate()
    {
        if(player.position.y <= 1.1 && player.position.x >= -8.0 && player.position.x <= 8.0)
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Player movement Jump from user input "w"
        if (Input.GetKey("w") && onGround == true)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }

        // Player Movement Right from user input "d"
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0);
        }

        // Player Movement Left from user input "a"
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0);
        }
    }
}
