using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeamLogic : MonoBehaviour
{
    public CalculateTrajectory player1;
    public Movement movePlayer1;
    public Shoot shootPlayer1;
    public Transform transPlayer1;

    public CalculateTrajectory player2;
    public Movement movePlayer2;
    public Shoot shootPlayer2;
    public Transform transPlayer2;


    private Vector3 initialPos1;
    private Vector3 initialRot1;

    private Vector3 initialPos2;
    private Vector3 initialRot2;
    private void Start()
    {
        initialPos1 = transPlayer1.position;
        initialRot1 = transPlayer1.eulerAngles;

        initialPos2 = transPlayer2.position;
        initialRot2 = transPlayer2.eulerAngles;
    }

    bool hasEnteredIf = false;
    void goBack(Movement movement,Transform playerTr ,Vector3 defaultPos, Vector3 defaultRot)
    {
        movement.W = false;
        Rigidbody rb = movement.Rb;
        if (playerTr.position.z > defaultPos.z + 0.25f)
        {          
            rb.AddForce(0, 0, -movement.movementForce/2 * Time.deltaTime, ForceMode.VelocityChange);
        } 
        else if(playerTr.position.z < defaultPos.z - 0.25f)
        {
            rb.AddForce(0, 0, movement.movementForce/2 * Time.deltaTime, ForceMode.VelocityChange);
        }

    }
    void goForward(Movement movement, Transform playerTr, Vector3 defaultRot, CalculateTrajectory trajectory)
    {
        playerTr.eulerAngles = new Vector3(0,trajectory.PlayerAngle + defaultRot.y,0);
        movement.W = true;
        hasEnteredIf = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    { 
        if (Mathf.Abs(player1.PlayerAngle) < Mathf.Abs(player2.PlayerAngle))
        {         
            shootPlayer1.CanShoot = true;
            goForward(movePlayer1, transPlayer1, initialRot1, player1);

            shootPlayer2.CanShoot = false;
            goBack(movePlayer2, transPlayer2, initialPos2, initialRot2);
        }
        else
        {            
            shootPlayer1.CanShoot = false;
            goBack(movePlayer1, transPlayer1, initialPos1, initialRot1);

            shootPlayer2.CanShoot = true;
            goForward(movePlayer2, transPlayer2, initialRot2, player2);
        }

       
    }
}
