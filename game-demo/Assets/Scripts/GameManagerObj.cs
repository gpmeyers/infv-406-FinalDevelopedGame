using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerObj : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    // Function for the Game Manager to perform tasks for endgame state
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            FindObjectOfType<Score>().gameOver = true; // Stop the scoreboard from increasing to show the player's final score
            Invoke("Restart", restartDelay);
        }
    }

    // Function to restart the game
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
