using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public ParticleSystem thrustparticles;

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
            thrustparticles.gameObject.SetActive(true);
        }

        else
        {
            thrustparticles.gameObject.SetActive(false);
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
        rb.freezeRotation = true; // we can only manually rotate the rocket and if hit with something wont rotate
        transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
        rb.freezeRotation = false; // the physics system work again for rotation when hitting with something
    }
}
