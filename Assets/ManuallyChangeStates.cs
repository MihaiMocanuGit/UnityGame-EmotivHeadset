using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManuallyChangeStates : MonoBehaviour
{
    public short state = -2; // -2, -1, 0, 1, -2, -1 .... -2 = does not overrides;
    // Start is called before the first frame update
    void Start()
    {
        state = -2;
    }

    // Update is called once per frame
    public void ChangeState()
    {
        state++;
        if (state > 1)
            state = -2;
    }
}
