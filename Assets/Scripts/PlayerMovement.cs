using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewardForce = 15f;
    public bool isGrounded = true;
    public float jump = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sidewardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s")) 
        {
            rb.AddForce(0, 0, -sidewardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Only allow jumping when grounded and space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            isGrounded = false;
        }


        if ( rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }

    // Add this method to check for ground collision
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the ground
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
        }
    }

}

// add a check for obstacles it should jump on its surface too