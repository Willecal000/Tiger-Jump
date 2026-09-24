using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    private bool Won;
    [SerializeField] private GameObject Winscreen;

    public void Win()
    {
        Won = true;
        Winscreen.SetActive(true);

        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Tiger Jungle Jump");
    }

    public void Quit()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
