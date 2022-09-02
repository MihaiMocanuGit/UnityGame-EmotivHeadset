using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShoot : MonoBehaviour
{
    public Shoot shoot;
    public PointLimit limit;

    public float angle1, angle2;

    private void Start()
    {
        angle1 = limit.Angle1;
        angle2 = limit.Angle3;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        shoot.tryShoot(Random.Range(angle1,angle2)+Random.Range(-5f,5f), Random.Range(20, 50));      
    }
}
