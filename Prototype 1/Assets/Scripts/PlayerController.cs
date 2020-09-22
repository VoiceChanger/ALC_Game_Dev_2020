using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30;
    public float turnSpeed = 60; 
    
    public float horizontalInput;
    public float forwardInput;
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Moves the vehicle forward and back based on VerticalIput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Rotates the vehicle left and right based on HorizontalIput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
