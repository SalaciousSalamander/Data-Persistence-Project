using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{

    public TextMeshProUGUI BestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoreKeeper.Instance != null)
        {
            UpdateText();
        }
    }

    public void UpdateText()
    {
        
        BestScoreText.text = "Best Score: " + ScoreKeeper.Instance.Name + " : " + ScoreKeeper.Instance.Score;
    }
}
