using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public Scoring scoring;
    private Rigidbody rb;
    public Transform cornerPoint; // get position to calculate where to respawn the ball
    public float limitLowerSpeed, limitTime;
    public bool hasRespawned = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = (Rigidbody)GetComponent<Rigidbody>();
    }
    private bool enteredIf = false;
    private float time;

    [Range(-1,1)]
    short sideChoser = -1;
    int _spawnToPlayerChanges = 50;
    public int SetSpawnToPlayerChances
    {
        set { _spawnToPlayerChanges = value;}
    }
    public void respawn()
    {
        scoring.OnRespawnEnter();
        Random.InitState(System.DateTime.Now.Millisecond);
        rb.velocity = new Vector3(0, 0, 0);
        int randNo = Random.Range(0, 100);
        if (randNo <= _spawnToPlayerChanges)
            transform.position = new Vector3(cornerPoint.position.x * 95/ 100 * sideChoser, cornerPoint.position.y + 1, -cornerPoint.position.z / 2);
        else 
            transform.position = new Vector3(cornerPoint.position.x * 95 / 100 * sideChoser, cornerPoint.position.y + 1, cornerPoint.position.z / 2);

        hasRespawned = true;
        
    }
    void respawnTimeout()
    {
        if (rb.velocity.magnitude <= limitLowerSpeed && enteredIf == false)
        {
            enteredIf = true;
            time = Time.realtimeSinceStartup;
            hasRespawned = false;
        }
        else if (rb.velocity.magnitude > limitLowerSpeed)
        {
            enteredIf = false;
            hasRespawned = false;
        }
        if (Time.realtimeSinceStartup - time >= limitTime && enteredIf == true)
        {
            respawn();
            enteredIf = false;
        }
    }

    void respawnOutOfBounds()
    {
        if (transform.position.y <= 0.175)
            respawn();
        else
            hasRespawned = false;
    }
    void Update()
    {
        respawnTimeout();
        respawnOutOfBounds();
    }

    public bool SetSpawnToPlayer
    {
        set {
            sideChoser = 1; 
            if (value == true)
                sideChoser = -1;
        }
    }
}
