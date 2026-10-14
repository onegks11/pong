using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startSpeed = 5f;
    public float startX = 1f;

    private void Start()
    {
        LaunchBall();
    }

    public void ResetBall()
    {
        rb.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
    }

    public void LaunchBall()
    {
        Vector2 direction = new Vector2(startX, 0.5f).normalized;
        rb.linearVelocity = direction * startSpeed;
    }
}
