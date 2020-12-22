using UnityEngine;
using UnityEngine.SceneManagement; // must call SceneManagement to Load scene

public class SceneLoader : MonoBehaviour
{
    // I need to create a way to load the game.
    public void LoadGame(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QutGame()
    {
        Application.Quit(); //quits the game.
        Debug.Log("Quit!"); //must also quit from Unity
    }

}


