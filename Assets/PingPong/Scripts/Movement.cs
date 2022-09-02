using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool w, a, s, d, space;
    private Rigidbody rb;

    public float movementForce, jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = (Rigidbody)GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(w == true)
        {
            w = false;
            rb.AddRelativeForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(s == true)
        {
            s = false;
            rb.AddRelativeForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(a == true)
        {
            a = false;
            rb.AddRelativeForce(0, 0, movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if(d == true)
        {
            d = false;
            rb.AddRelativeForce(0, 0, -movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(space == true)
        {
            rb.AddRelativeForce(0, jumpForce  * Time.deltaTime,0, ForceMode.VelocityChange);
            space = false;
        }
    }

    public Rigidbody Rb
    {
        get { return rb;}
    }
    public bool W
    {
        set { w = value;}
    }
    public bool A
    {
        set { a = value; }
    }
    public bool S
    {
        set { s = value; }
    }
    public bool D
    {
        set { d = value; }
    }
    public bool Space
    {
        set { space = value; }
    }

}
