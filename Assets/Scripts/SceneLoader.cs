using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        if (currentSceneIndex + 2 == SceneManager.sceneCountInBuildSettings)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
        
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
        Cursor.visible = true;
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("Game Over");
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
