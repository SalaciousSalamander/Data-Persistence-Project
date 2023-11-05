using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper Instance;

    public String Name = "";
    public String NewName;
    public int Score = 0;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        LoadText();
    }


    [System.Serializable]
    class SaveData
    {
        public String Name;
        public int Score;
    }

    public void SaveText()
    {
        SaveData data = new SaveData();
        data.Name = Name;
        data.Score = Score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadText()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Name = data.Name;
            Score = data.Score;
        }
    }
}
