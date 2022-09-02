using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePassing : MonoBehaviour
{
    [Range(-1, 1)]
    public short state;
    [Space]
    private Data data;
    public AIShoot[] shoot;
    public ManuallyChangeStates overrideState;
    [Range(0f, 1f)]
    public float lowerStressLimit, upperStresslimit;
   

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
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle2 + 7;
                    shoot[i].angle2 = shoot[i].limit.Angle3;
                }
                state = -1;
            }
            else if (data.stress > upperStresslimit)
            {
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle1;
                    shoot[i].angle2 = shoot[i].limit.Angle2 - 7;
                }
                state = 1;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle1;
                    shoot[i].angle2 = shoot[i].limit.Angle3;
                }
                state = 0;
            }
        }
        else
        {
            if (overrideState.state == -1)
            {
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle2 + 7;
                    shoot[i].angle2 = shoot[i].limit.Angle3;
                }
                state = -1;
            }
            else if (overrideState.state == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle1;
                    shoot[i].angle2 = shoot[i].limit.Angle2 - 7;
                }
                state = 1;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    shoot[i].angle1 = shoot[i].limit.Angle1;
                    shoot[i].angle2 = shoot[i].limit.Angle3;
                }
                state = 0;
            }
        }


    }
}
