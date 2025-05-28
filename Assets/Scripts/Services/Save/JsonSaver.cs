using System.IO;
using UnityEngine;

public class JsonSaver : ISaver
{
    public void SaveScore(int score, string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = Path.Combine(Application.persistentDataPath, "score.json");

        var json = JsonUtility.ToJson(new ScoreData { Score = score });
        File.WriteAllText(path, json);
    }

    [System.Serializable]
    private class ScoreData
    {
        public int Score;
    }
}