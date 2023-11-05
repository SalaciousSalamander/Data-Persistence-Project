using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI BestScoreText;
    public TMP_InputField TMPInputField;

    // Start is called before the first frame update
    void Start()
    {
        if (ScoreKeeper.Instance != null)
        {

            BestScoreText.text = "Best Score: " + ScoreKeeper.Instance.Name + " : " + ScoreKeeper.Instance.Score;
        }
    }

    public void LoadMain()
    {
        ScoreKeeper.Instance.NewName = TMPInputField.text;
        Debug.Log(ScoreKeeper.Instance.Name);
        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
        //ScoreKeeper.Instance.SaveText();

    #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
    #else
                Application.Quit(); // original code to quit Unity player
    #endif
    }
}
