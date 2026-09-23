using UnityEngine;

public class Callwin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("touch");
        FindAnyObjectByType<YouWin>().Win();
        
    }
}