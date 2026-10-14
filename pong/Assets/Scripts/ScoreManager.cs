using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text leftScoreText;
    public TMP_Text rightScoreText;

    private int leftScore = 0;
    private int rightScore = 0;

    public void AddLeftScore()
    {
        leftScore++;
        UpdateScoreUI();
    }

    public void AddRightScore()
    {
        rightScore++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }
}
