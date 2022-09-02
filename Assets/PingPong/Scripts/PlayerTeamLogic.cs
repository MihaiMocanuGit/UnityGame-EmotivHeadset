using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeamLogic : MonoBehaviour
{
    public CalculateTrajectory player;
    public Movement movePlayer;
    public Shoot shootPlayer;
    public Transform transPlayer;

    public CalculateTrajectory bot;
    public Movement moveBot;
    public Shoot shootBot;
    public Transform transBot;


    private Vector3 initialPos2;
    private Vector3 initialRot2;
    private void Start()
    {
        initialPos2 = transBot.position;
        initialRot2 = transBot.eulerAngles;
    }

    void goBack(Movement movement, Transform playerTr, Vector3 defaultPos, Vector3 defaultRot)
    {
        movement.W = false;
        Rigidbody rb = movement.Rb;
        if (playerTr.position.z > defaultPos.z + 0.25f)
        {
            rb.AddForce(0, 0, -movement.movementForce / 2 * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (playerTr.position.z < defaultPos.z - 0.25f)
        {
            rb.AddForce(0, 0, movement.movementForce / 2 * Time.deltaTime, ForceMode.VelocityChange);
        }

    }
    void goForward(Movement movement, Transform playerTr, Vector3 defaultRot, CalculateTrajectory trajectory)
    {
        playerTr.eulerAngles = new Vector3(0, trajectory.PlayerAngle + defaultRot.y, 0);
        movement.W = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(player.PlayerAngle) < Mathf.Abs(bot.PlayerAngle))
        {
            shootBot.CanShoot = false;
            goBack(moveBot, transBot, initialPos2, initialRot2);
        }
        else
        {
            shootBot.CanShoot = true;
            goForward(moveBot, transBot, initialRot2, bot);
        }


    }
}
