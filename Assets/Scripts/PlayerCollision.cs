using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerMovement movement;

    public float jumpForce;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "Launch Pad")
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
    
}
