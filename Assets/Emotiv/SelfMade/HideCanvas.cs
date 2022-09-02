using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideCanvas : MonoBehaviour
{
    public GameObject holder1,holder2, pingPong;
    public Image image;

    public void hideCanavas(bool state)
    {
        image.enabled = !state;
        holder1.SetActive(!state);
        holder2.SetActive(!state);
        pingPong.SetActive(state);
        Debug.Log("Button is " + state);
    }
    

}
