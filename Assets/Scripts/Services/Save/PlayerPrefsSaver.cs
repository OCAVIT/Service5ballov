using UnityEngine;

public class PlayerPrefsSaver : ISaver
{
    private const string ScoreKey = "Score";

    public void SaveScore(int score, string path = null)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
    }
}
