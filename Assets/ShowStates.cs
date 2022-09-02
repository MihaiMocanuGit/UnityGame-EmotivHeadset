using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStates : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public GameObject scenarios;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "States" 
                    + "\n Passing:" +scenarios.GetComponent<ChangePassing>().state 
                    + "\n Points:" + scenarios.GetComponent<AddRandomPoints>().state 
                    + "\n Respawn:" + scenarios.GetComponent<AddRandomPoints>().state;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        txt.text = "States"
            + "\n Passing:" + scenarios.GetComponent<ChangePassing>().state
            + "\n Points:" + scenarios.GetComponent<AddRandomPoints>().state
            + "\n Respawn:" + scenarios.GetComponent<ChangeRespawnPlaces>().state;
    }
}
