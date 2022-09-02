using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float sensitivity;
    Vector3 _defaultPos;
    // Start is called before the first frame update
    void Start()
    {
        _defaultPos = transform.localPosition;
    }

    Vector3 distance;
    // Update is called once per frame
    void Update()
    {
        distance += new Vector3(-Mathf.Cos(transform.eulerAngles.x * Mathf.Deg2Rad) * Input.GetAxis("Mouse ScrollWheel"), Mathf.Sin(transform.eulerAngles.x * Mathf.Deg2Rad) * Input.GetAxis("Mouse ScrollWheel"), 0);

        transform.localPosition = _defaultPos + distance * -sensitivity;
        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, -10, 0.4f), Mathf.Clamp(transform.localPosition.y, 1.1f, 10), Mathf.Clamp(transform.localPosition.z, -0.1f, 0.1f));
    }
}
