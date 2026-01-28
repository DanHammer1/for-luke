using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 velocity;
    Vector3 lastFramePosition;
    Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-1.5f, -1.5f, 0);
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    
    void CheckInput()
    {
        Rigidbody2D rigidbody = transform.GetComponent<Rigidbody2D>();

        if (Input.GetKey("a"))
        {
            velocity = new Vector3(-30f, 0, 0);  
        }

        if (Input.GetKey("d"))
        {
            velocity = new Vector3(30f, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            velocity = new Vector3(0, 30f, 0);
        }

        if (Input.GetKey("s"))
        {
            velocity = new Vector3(0, -30f, 0);
        }
    }
    void FixedUpdate()
    {
        if ((transform.position - lastFramePosition).magnitude <= 0.01f)
        {
            CheckInput();
        }

        lastFramePosition = transform.position;

        rigidbody.AddForce(velocity);
    }
}

