using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float RestartDelay = 2f;

    public GameObject completelevelUI;

    public void Completelevel ()
        {
          completelevelUI.SetActive(true);
        }

    // Start is called before the first frame update
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartDelay);
        }
       
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
