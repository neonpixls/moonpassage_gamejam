using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variable that references player
    public Transform target;

    
    void Update()
    {
        //check if the player y value is greater than the camera y value
        if (target.position.y > transform.position.y)
        {
            transform.position = new Vector3 (transform.position.x, target.position.y, transform.position.z);
        }
    }
}
