using UnityEngine;

public class HazardScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);

        FindAnyObjectByType<YouDied>().Dead();
        
        Debug.Log(collision.gameObject.name);
    }
}