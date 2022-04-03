using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]float thrust = 4f;
    [SerializeField] float rotationSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrust * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationSpeed);
        }
    }

    private void ApplyRotation(float rotationThrust)
    {
        transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
    }
}
