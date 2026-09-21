using UnityEngine;
using UnityEngine.UI;

public class TriggerBox : MonoBehaviour
{
    Animator m_Animator;

    public string Trigger;
    public GameObject parentObject;
    public Collider2D ColliderCheck;
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
        if (ColliderCheck.IsTouching(Detect))
        {
            m_Animator.SetTrigger(Trigger);
            
        }
    }
}
