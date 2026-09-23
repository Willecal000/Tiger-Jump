using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDied : MonoBehaviour
{
    private bool isDead;
    [SerializeField] private GameObject YouDiedScreen;

    public void Dead()
    {
        isDead = true;
       YouDiedScreen.SetActive(true);

        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Tiger Jungle Jump");
        Time.timeScale = 1;
    }
}
