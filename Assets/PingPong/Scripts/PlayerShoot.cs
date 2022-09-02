using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Shoot shoot;
    public PlayerControl control;
    private void Start()
    {
        shoot.CanShoot = true;
    }
    void FixedUpdate()
    {
        //shoot.CanShoot = true;
        float x = Input.mousePosition.x - Screen.width / 2;
        float y = Input.mousePosition.y - Screen.height / 2;

        float yaw = 90 * x / (Screen.width / 2);
        float pitch = 60 * y / (Screen.height / 2);
        if (control.mouse0 == true)
        {
            control.mouse0 = false;
            shoot.tryShoot(yaw, pitch/1.5f);
        }
        // -90......-Screen.width/2
        //  yaw ..... x
        // => yaw = 90 * x / Screen.width/2
    }
}
