using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRandomPoints : MonoBehaviour
{
    [Range(-1, 1)]
    public short state;
    [Space]
    Data data;
    public ChangeScore changeScore;
    public ManuallyChangeStates overrideState;
    [Range(0f, 1f)]
    public float lowerStressLimit, upperStresslimit;
    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<Data>();
        InvokeRepeating("randPoint", 0, 2.5F);
    }

    // Update is called once per frame
    void randPoint()
    {
        if (overrideState.state == -2)
        {
            if (data.stress < lowerStressLimit)
            {              
                if (10 > Random.Range(0, 100))
                {
                    changeScore.UpdateScore(0, 1);
                }
                state = -1;
            }
            else if (data.stress > upperStresslimit)
            {
                if (10 > Random.Range(0, 100))
                {
                    changeScore.UpdateScore(1, 0);
                }
                state = 1;
            }
            else
            {
                state = 0;
            }
        }
        else
        {
            if (overrideState.state == -1)
            {
                if (10 > Random.Range(0, 100))
                {
                    changeScore.UpdateScore(0, 1);
                }
                state = -1;
            }
            else if (overrideState.state == 1)
            {
                if (10 > Random.Range(0, 100))
                {
                    changeScore.UpdateScore(1, 0);
                }
                state = 1;
            }
            else
            {
                state = 0;
            }
        }

    }
}
