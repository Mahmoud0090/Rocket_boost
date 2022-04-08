using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowup : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    [SerializeField] bool followOnYAxis = false;

    Vector3 cameraCurrentPos;
    float cameraYPos; 

    void Start()
    {
        cameraCurrentPos = transform.position;
        cameraYPos = cameraCurrentPos.y;
    }
    void Update()
    {
        if (followOnYAxis) 
        {
            
            if(rocket.transform.position.y <= cameraYPos)
            {
                transform.position = new Vector3(rocket.transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(rocket.transform.position.x, rocket.transform.position.y, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3(rocket.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
