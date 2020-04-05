using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Function will run anytime our player collides with another rigidbody
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.rb.constraints = RigidbodyConstraints.None;
            movement.enabled = false;
        }
    }
}
