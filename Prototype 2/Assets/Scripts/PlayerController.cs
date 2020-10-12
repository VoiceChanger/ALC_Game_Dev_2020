using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public GameObject projectileFood;

    // Update is called once per frame
    void Update()
    {
        //Collect Input Date on Horizontal Controls
        horizontalInput = Input.GetAxis("Horizontal");
       
        //Moves the player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Places a boundary on the left side
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Places a boundary on the right side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectileFood, transform.position, projectileFood.transform.rotation);
        }
            
    }
}
