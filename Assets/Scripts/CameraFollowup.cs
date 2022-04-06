using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowup : MonoBehaviour
{
    [SerializeField] GameObject rocket;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(rocket.transform.position.x, transform.position.y, transform.position.z);
    }
}
