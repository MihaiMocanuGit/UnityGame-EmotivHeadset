using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody ballRb;
    public Transform ballTr;
    public Vector3 shootArea;
    public float force;
    public Scoring scoring;
    private CalculateTrajectory trajectory;
    private AudioSource audioSrc;
    private bool canShoot;

    public bool CanShoot
    {
        set { canShoot = value; }
    }

    private void Start()
    {
        trajectory = GetComponent<CalculateTrajectory>();
        audioSrc = GetComponent<AudioSource>();
    }


    private bool isInArea()
    {
        if(Mathf.Abs(transform.position.x - ballTr.position.x) <= shootArea.x
            && Mathf.Abs(transform.position.y - ballTr.position.y) <= shootArea.y 
            && Mathf.Abs(transform.position.z - ballTr.position.z) <= shootArea.z)
            return true;
        return false;
    }
    bool isAlreadyShot = false;


    private void shootBall(float yaw, float pitch)
    {
        ballRb.velocity = new Vector3(0, 0, 0);
        ballRb.AddForce(force * Mathf.Cos(yaw * Mathf.Deg2Rad) * Mathf.Cos(pitch * Mathf.Deg2Rad) * Time.deltaTime, force * Mathf.Sin(pitch * Mathf.Deg2Rad) * Time.deltaTime, force * Mathf.Sin(-yaw * Mathf.Deg2Rad) * Mathf.Cos(pitch * Mathf.Deg2Rad) * Time.deltaTime, ForceMode.Impulse);
        isAlreadyShot = true;
    }


    public bool tryShoot(float yaw, float pitch)
    {
        if (isInArea() == true && isAlreadyShot == false)// && canShoot == true)
        {
            audioSrc.Play();
            shootBall(yaw,pitch);
            scoring.SetBallShooter = gameObject;
            trajectory.enterOnBeingShot();
            return true;
        }        
        else if (isInArea() != true)
        {
            isAlreadyShot = false;
        }
        return false;

    }

}
