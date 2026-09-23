using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    [SerializeField] private GameObject _pauseMenu; // serializefield is so you can access the variable from the inspector but not from other scripts so its not public 100%
    public void Pause()
    {
        isPaused = true;
        _pauseMenu.SetActive(true);

        Time.timeScale = 0;
    }
    public void Resume()
    {
        isPaused = false;
        _pauseMenu.SetActive(false);

        Time.timeScale = 1;
    }
    public void Toggle(InputAction.CallbackContext ctx)
    {
        isPaused = !isPaused;
        _pauseMenu.SetActive(isPaused);

        Time.timeScale = isPaused ? 0 : 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
