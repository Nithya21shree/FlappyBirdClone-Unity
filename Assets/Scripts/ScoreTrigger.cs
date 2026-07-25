using UnityEngine;

using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            Debug.Log("Score Increased");
            FindObjectOfType<ScoreManager>().AddScore();
        }
    }
}