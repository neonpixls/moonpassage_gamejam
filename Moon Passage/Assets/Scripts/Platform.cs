using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float jumpForce = 10.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if player is coming from below or from above
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                //set velocity and set speed of traveling upwards directly
                Vector2 velocity = rb.velocity;
                //control de y velocity of the player after it hits platform
                velocity.y = jumpForce;
                //set vector back to original
                rb.velocity = velocity;
            }
        }
        
    }
}
