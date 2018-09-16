using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void completeLevel()
    {
        Debug.Log("You WON !");
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
