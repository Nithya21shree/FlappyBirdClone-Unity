using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit : " + collision.gameObject.name);

        if (collision.gameObject.name.Contains("TopPipe") ||
            collision.gameObject.name.Contains("BottomPipe") ||
            collision.gameObject.name.Contains("Ground"))
        {
            gameManager.GameOver();
        }
    }
}