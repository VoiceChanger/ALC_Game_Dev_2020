using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 30;
    public float rotationSpeed = 50;
    public float verticalInput = 100;
    public float horizontalInput = 30;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical and horizontal input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
         transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * speed * verticalInput);
    }
}
