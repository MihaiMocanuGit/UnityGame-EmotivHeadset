using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ChangeScore : MonoBehaviour
{
    public TextMeshProUGUI score;

    public Despawn despawn;
    private int _teamScore, _enemyScore;
    private void Start()
    {
 
        score.text = "Score:\n <color=red>" + 0 + "</color>:<color=blue>" + 0 + "</color>";
    }

    public void OnChangedScoredEnter(int teamScore, int enemyScore)
    {
        score.text = "Score\n <color=red>" + teamScore + "</color>:<color=blue>" + enemyScore + "</color>";

    }

    public void UpdateScore(short teamScoreAdd, short enemyScoreAdd)
    {
        _teamScore += teamScoreAdd;
        _enemyScore += enemyScoreAdd;

        despawn.SetSpawnToPlayer = true;
        if (enemyScoreAdd > teamScoreAdd)
            despawn.SetSpawnToPlayer = false;

        score.text = "Score\n <color=red>" + _teamScore + "</color>:<color=blue>" + _enemyScore + "</color>";
    }


}
