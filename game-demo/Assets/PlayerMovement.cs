using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    private Vector3 moveVector;

    public float speed = 5f;

    public float jumpForce = 1000f;

    private bool onGround = true;

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

        // Jump mechanic
        if((Input.GetKey("w") || Input.GetKey("up")) && onGround)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }

        // Reset the movement vector for a new update
        moveVector = Vector3.zero;

        // Player can not move horizontally while jumping
        if (onGround)
        {
            moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        }

        // Player will always receive a constant forward speed whether in the air or on the ground
        moveVector.z = speed;

        // Update the position of the RigidBody (our player character)
        rb.position = rb.position + (moveVector * Time.deltaTime);
    }
}