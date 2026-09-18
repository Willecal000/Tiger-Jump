using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    Animator m_Animator;
    public GameObject parentObject;
    public Collider2D Collider;
    public Collider2D Detect;
    ContactFilter2D noFilter;
   
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = parentObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Collider2D detect in Physics2D.GetContactColliders(Collider, noFilter))
        {
            m_Animator.SetTrigger("Close");
        }
    }
}
