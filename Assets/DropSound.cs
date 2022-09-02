using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSound : MonoBehaviour
{
    AudioSource audioSrc;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        audioSrc.volume = Mathf.Abs(Mathf.Pow(rb.velocity.y,1.6f))/7;
        audioSrc.Play();
    }
}
