using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    public ChangeScore changeScore;
    public Despawn despawn;
    private GameObject ballShooter;
    public int enemyScore, teamScore;

    private bool scoreIsAlreadySet = false;
    // Start is called before the first frame update
    void Start()
    {
        ballShooter = null;
    }

    bool illegalTeamCollisionChecker = false;
    bool illegalEnemyCollisionChecker = false;
    private void OnCollisionEnter(Collision collision) //respawn and give point when it touches a base
    {
        if (ballShooter != null)
        {
            scoreIsAlreadySet = true;
            if (collision.gameObject.tag == "EnemyBase" && ballShooter.tag == "Team")
            {
                /* teamScore++;
                 changeScore.OnChangedScoredEnter(1, enemyScore);
                 despawn.SetSpawnToPlayer = true;
                 despawn.respawn(); */

                changeScore.UpdateScore(1, 0);
                despawn.respawn();
            }
            else if (collision.gameObject.tag == "TeamBase" && ballShooter.tag == "Enemy")
            {
                /*enemyScore++;
                changeScore.OnChangedScoredEnter(teamScore, enemyScore);
                despawn.SetSpawnToPlayer = false;
                despawn.respawn();*/

                changeScore.UpdateScore(0, 1);
                despawn.respawn();
            }
            else
            {
                
                scoreIsAlreadySet = false;
            }


            if (collision.gameObject.tag == "Team")   // if player stops the ball with his body, he can  change the course of the ball and make it miss, getting an illegal point
                illegalTeamCollisionChecker = true;
            else if (collision.gameObject.tag == "Enemy")
                illegalEnemyCollisionChecker = true;
        }
        
    }
    private void FixedUpdate()
    {
        if (ballShooter != null)
        {
            if (ballShooter.tag == "Team")
            {
                illegalTeamCollisionChecker = false;
            }
            else if (ballShooter.tag == "Enemy")
            {
                illegalEnemyCollisionChecker = false;
            }
        }
    }
    public void OnRespawnEnter()
    {
        if (ballShooter != null)
        {
            if (illegalTeamCollisionChecker == true)
            {
                /*
                despawn.SetSpawnToPlayer = false;
                enemyScore++;
                changeScore.OnChangedScoredEnter(teamScore, enemyScore);
                */

                changeScore.UpdateScore(0, 1);

                illegalTeamCollisionChecker = false;
            }
            else if (illegalEnemyCollisionChecker == true)
            {
                /*
                despawn.SetSpawnToPlayer = true;                           //TODO: when points change, automatically change spawnSide and score, in OnChangedScored;
                teamScore++;
                changeScore.OnChangedScoredEnter(teamScore, enemyScore);
                */

                changeScore.UpdateScore(1, 0);

                illegalEnemyCollisionChecker = false;
            }
            else if (scoreIsAlreadySet == false)
            {
                if (ballShooter.tag == "Team")
                {
                    //despawn.SetSpawnToPlayer = false;
                    //enemyScore++;

                    changeScore.UpdateScore(0, 1);
                }
                else if (ballShooter.tag == "Enemy")
                {
                    //despawn.SetSpawnToPlayer = true;
                    //teamScore++;
                    changeScore.UpdateScore(1, 0);
                }
                //changeScore.OnChangedScoredEnter(teamScore,enemyScore);          
            }
            ballShooter = null;
        }

    }

    public GameObject SetBallShooter
    {
        set { ballShooter = value; }
    }
}
