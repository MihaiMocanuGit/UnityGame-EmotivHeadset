using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointLimit : MonoBehaviour
{
    public Transform pointTrLeft;
    public Transform pointTrMiddle;
    public Transform pointTrRight;

    private float angleLimit1, angleLimit2, angleLimit3;
    float getLimitAngle(Transform pointTr)
    {
        Vector3 distance = pointTr.position - transform.position;
        return (distance.x > 0) ? -Mathf.Rad2Deg * Mathf.Atan(distance.z / distance.x) : -Mathf.Rad2Deg * Mathf.Atan(distance.z / distance.x) + 180;
    }

    public float Angle1
    {
        get { return getLimitAngle(pointTrLeft); }
    }
    public float Angle2
    {
        get { return getLimitAngle(pointTrMiddle); }
    }
    public float Angle3
    {
        get { return getLimitAngle(pointTrRight); }
    }
}
