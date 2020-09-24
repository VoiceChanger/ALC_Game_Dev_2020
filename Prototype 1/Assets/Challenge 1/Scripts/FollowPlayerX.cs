using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new Vector3(30, 10, 10);

    // Update is called once per frame
    void Update()
    {
        // Makes the camera follow the plane from the side
        transform.position = plane.transform.position + offset;
    }
}
