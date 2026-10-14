using UnityEngine;

public class GoalDetector : MonoBehaviour
{
    public ScoreManager scoreManager;
    public BallMove ballMove;
    public bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Ball"))
            return;

        if (isLeftGoal)
        {
            scoreManager.AddRightScore();
            ballMove.startX = -1f;
        }
        else
        {
            scoreManager.AddLeftScore();
            ballMove.startX = 1f;
        }

        ballMove.ResetBall();
        ballMove.LaunchBall();
    }
}
