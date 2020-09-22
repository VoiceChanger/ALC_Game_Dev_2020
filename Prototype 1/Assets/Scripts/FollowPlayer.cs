using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7,-10);
   
    // Update is called once per frame
    void Update()
    {
        // Makes the camera follow the movements of the player
        transform.position = player.transform.position + offset;
    }
}
