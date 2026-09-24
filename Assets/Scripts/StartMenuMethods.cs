using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuMethods : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Tiger Jungle Jump");
    }

    public void QuitButton()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}