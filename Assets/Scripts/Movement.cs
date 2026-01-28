using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            Rigidbody2D rigidbody = transform.GetComponent<Rigidbody2D>();
            rigidbody.linearVelocity = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
        }

        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
        }


    }
}