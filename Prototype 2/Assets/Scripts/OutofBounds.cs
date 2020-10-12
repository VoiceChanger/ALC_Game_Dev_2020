﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float topBounds = 35.0f;
    public float lowerBounds = -15.0f;

    // Update is called once per frame
    void Update()
    {
        // Deletes any gameObject that try to go past the topBounds
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }    
         
         // Deletes any gameObject that try to go past the lowerBounds
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }   
    
    }
}
