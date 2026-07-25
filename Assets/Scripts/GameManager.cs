using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject startPanel;

    private bool gameOver = false;
    private bool gameStarted = false;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        startPanel.SetActive(true);
        Time.timeScale = 0f; // Start screen varumbodhu game pause
    }

    private void Update()
    {
        // First Space -> Start Game
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;
            startPanel.SetActive(false);
            Time.timeScale = 1f;
        }

        // Game Over apram Space -> Restart
        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE PRESSED");
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER FUNCTION CALLED");
        gameOverPanel.SetActive(true);
        gameOverPanel.transform.SetAsLastSibling();
        gameOver = true;
        Time.timeScale = 0f;
    }
}