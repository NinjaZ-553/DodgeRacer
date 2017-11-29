using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference to Player Rigidbody
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


	// Unity likes FixedUpdate better. Use when doing physics
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Use * Time.deltaTime to even out framerate differences

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
