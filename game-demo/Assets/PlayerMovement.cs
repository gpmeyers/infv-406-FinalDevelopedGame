using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewardForce = 600f;
    public float jumpForce = 400f;

    // We are using Fixed Update because we are using this for player physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // TODO: Make this so that the jump key feels more like a jump and not flying
        // Player movement Jump from user input "w"
        if (Input.GetKey("w"))
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
