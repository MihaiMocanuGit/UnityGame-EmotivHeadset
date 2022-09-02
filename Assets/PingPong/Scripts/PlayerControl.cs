using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Movement movement;
    public bool mouse0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            movement.W = true;
        else if(Input.GetKey(KeyCode.S))
            movement.S = true;

        if (Input.GetKey(KeyCode.A))
            movement.A = true;
        else if (Input.GetKey(KeyCode.D))
            movement.D = true;

        if (Input.GetKey(KeyCode.Mouse0))
            mouse0 = true;

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();

    }
}
