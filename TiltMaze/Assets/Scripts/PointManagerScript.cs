using UnityEngine;
using TMPro;

public class PointManagerScript : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text  = "Score: " + score;
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text  = "Score: " + score;
        Debug.Log("Score: " + score);
    }
}