using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;
    public BestScore BestScore; 

    private void OnCollisionEnter(Collision other)
    {
        if (ScoreKeeper.Instance != null)
        {
            if (Manager.GetPoints() > ScoreKeeper.Instance.Score)
            {
                ScoreKeeper.Instance.Score = Manager.GetPoints();
                ScoreKeeper.Instance.Name = ScoreKeeper.Instance.NewName;
                ScoreKeeper.Instance.SaveText();
                BestScore.UpdateText();
            }
        }
        Destroy(other.gameObject);
        Manager.GameOver();
    }
}
