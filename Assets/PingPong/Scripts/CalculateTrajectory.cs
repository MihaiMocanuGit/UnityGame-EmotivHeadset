using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateTrajectory : MonoBehaviour
{
    public Rigidbody ballRb;
    public Transform ballTr;

    public Transform middlePoint;


    //public float playerAngle;

    private Vector3 rot;
    void Start()
    {
        rot = transform.eulerAngles;
    }
    float calculatePlayerAngle()
    {
        float xb = ballTr.position.x - middlePoint.position.x;
        float xp = transform.position.x - middlePoint.position.x;
        float angleBall = -ballRb.velocity.z / ((ballRb.velocity.x == 0) ? 0.00001f : ballRb.velocity.x);
        float deltaZ = transform.position.z - ballTr.position.z;
        return Mathf.Rad2Deg * Mathf.Atan((xb * Mathf.Tan(angleBall) - deltaZ) / xp); 
    }
    float randAngleMultiplier = 1;
    public void enterOnBeingShot()
    {
        randAngleMultiplier = Random.Range(0.9f, 1.1f);
    }

    public float PlayerAngle
    {
        get 
        {
            //playerAngle = calculatePlayerAngle();
            //transform.eulerAngles = new Vector3(0, rot.y + playerAngle, 0);
            return calculatePlayerAngle()*randAngleMultiplier; 
        }
    }
}
