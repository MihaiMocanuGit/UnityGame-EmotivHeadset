using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowOverloadState : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public ManuallyChangeStates overload;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
        txt.text = overload.state + "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        txt.text = overload.state + "";
    }
}
