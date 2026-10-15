using UnityEngine;
using System.Collections;
using TMPro;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startSpeed = 5f;
    public float startX = 1f;

    public AudioSource audioSource;
    public AudioClip bounceSound;

    public TMP_Text countText;

    private void Start()
    {
        ResetAndLaunch();
    }

    public void ResetAndLaunch()
    {
        StartCoroutine(ResetAndLaunchRoutine());
    }

    private IEnumerator ResetAndLaunchRoutine()
    {
        ResetBall();

        countText.gameObject.SetActive(true);

        for(int i = 3; i>=1; i--)
        {
            countText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }

        countText.text = "GO!";
        LaunchBall();

        yield return new WaitForSeconds(0.2f);

        countText.gameObject.SetActive(false);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(bounceSound != null)
        {
            audioSource.PlayOneShot(bounceSound);
        }
    }
}
