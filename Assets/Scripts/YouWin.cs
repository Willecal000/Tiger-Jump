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
        SceneManager.LoadScene("Win");
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
