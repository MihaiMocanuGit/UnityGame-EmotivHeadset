using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Rigidbody rb;

    public float movementForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = (Rigidbody)GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.S))
            rb.AddForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(0,0,-movementForce * Time.deltaTime, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.D))
            rb.AddForce(0,0,movementForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
