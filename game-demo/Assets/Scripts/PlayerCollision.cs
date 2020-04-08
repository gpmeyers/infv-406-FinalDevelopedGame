using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    /*
     *Function will run anytime our player collides with another rigidbody
     * 
     * collisionInfo is a reference to the collision that we can obtain information from
     */
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.rb.constraints = RigidbodyConstraints.None; // Allow rotation for physics effects
            movement.enabled = false; // Disable Player movement
            FindObjectOfType<GameManagerObj>().EndGame();
        }
    }
}
