using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvements : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private bool m_FacingRight = true;  // For determining which way the player is currently facing.

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        // If the input is moving the player right and the player is facing left...
        if (movement.x > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (movement.x < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }


    private void FixedUpdate()
    {
        Vector2 newPos = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        if (Mathf.Abs(newPos.x) > 8.5)
        {
            newPos.x = (float)((newPos.x > 0) ? 8.5 : -8.5);
        }
        if (Mathf.Abs(newPos.y) > 4.5)
        {
            newPos.y = (float)((newPos.y > 0) ?  4.5 : -4.5);
        }
        rb.MovePosition(newPos);
    }


    void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
