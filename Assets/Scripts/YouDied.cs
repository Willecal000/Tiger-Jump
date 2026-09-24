using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDied : MonoBehaviour
{
    private bool isDead;
    [SerializeField] private GameObject YouDiedScreen;

    public void Dead()
    {
        SceneManager.LoadScene("Lose");
        Debug.Log("loaded lose scene");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Tiger Jungle Jump");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
