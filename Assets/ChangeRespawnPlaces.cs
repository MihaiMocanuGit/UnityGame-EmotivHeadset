using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ChangeRespawnPlaces : MonoBehaviour
{
    [Range(-1, 1)]
    public short state;
    [Space]
    Data data;
    public Despawn despawn;
    public ManuallyChangeStates overrideState;
    [Range(0f, 1f)]
    public float lowerStressLimit, upperStressLimit;
    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<Data>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (overrideState.state == -2)
        {
            if (data.stress < lowerStressLimit)
            {
                state = -1;
                despawn.SetSpawnToPlayerChances = 10;
            }
            else if (data.stress > upperStressLimit)
            {
                state = 1;
                despawn.SetSpawnToPlayerChances = 90;
            }
            else
            {
                state = 0;
                despawn.SetSpawnToPlayerChances = 60;
            }
        }
        else
        {
            if(overrideState.state == -1)
            {
                state = -1;
                despawn.SetSpawnToPlayerChances = 10;
            }
            else if(overrideState.state == 1)
            {
                state = 1;
                despawn.SetSpawnToPlayerChances = 90;
            }
            else
            {
                state = 0;
                despawn.SetSpawnToPlayerChances = 60;
            }
        }
    }
}
