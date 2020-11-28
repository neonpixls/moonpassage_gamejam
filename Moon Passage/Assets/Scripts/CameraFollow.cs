using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variable that references player
    public Transform target;
    public float smoothSpeed = .3f;

    private Vector3 currentVelocity;

    
    void LateUpdate()
    {
        //check if the player y value is greater than the camera y value
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed * Time.deltaTime);            
        }
    }
}
