using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Instance of the RigidBody associated with the player character
    public Rigidbody rb;

    // All of the forces associated with different types of movement
    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    public float jumpForce = 1000f;

    // Boolean to check if the player character is grounded (~0.1 tolerance)
    private bool onGround = true;

    // This will be called once
    void start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationX;
    }

    // This will be called once per frame. Using FixedUpdate because some physics will be declared here.
    void FixedUpdate()
    {
        // Check for if our Rigid Body is on the ground or not
        if(rb.position.y <= 1.1 && rb.position.x <= 8 && rb.position.x >= -8)
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }

        // Forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Jump mechanic
        if((Input.GetKey("w") || Input.GetKey("up")) && onGround)
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;

            Vector3 sidev = rb.velocity;
            sidev.x = 0.0f;
            rb.velocity = sidev;

            rb.AddForce(0, jumpForce * Time.deltaTime, 0);

            rb.constraints = RigidbodyConstraints.None;
        }

        // Add velocity going right
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Add velocity going left
        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerObj>().EndGame();
        }
    }
}