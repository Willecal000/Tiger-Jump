using UnityEngine;

public class HazardScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log(collision.gameObject.name);
    }
}