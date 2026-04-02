using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
   private int totalScore = 0;
    public TMP_Text ScoreDisplay;

    private void Start()
    {
        
    }

    public void AddPoints(int points)
    {
        totalScore += points;
        ScoreDisplay.text = ($"SCORE: {totalScore}");
        //Debug.Log($"Total Score: {totalScore}");
    }
}
