using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    bool gameEnded = false;

    public void CompleteLevel()
    {
        Debug.Log("Level Won");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Replay", restartDelay);
        }
    }

    public void Replay()
    {
        FindAnyObjectByType<PlayerMovement>().ResetPosition();
        FindAnyObjectByType<InputHandler>().StartReplay();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
