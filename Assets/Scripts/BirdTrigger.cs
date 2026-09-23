using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BirdTrigger : MonoBehaviour
{
    Animator m_Animator;

    public string Trigger;
    public GameObject parentObject;
    public Collider2D ColliderCheck;
    public Collider2D Detect;

    public GameObject Appear;
    public GameObject Dissappear;
    ContactFilter2D noFilter;
    AudioSource audioData;
   
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        audioData = GetComponent<AudioSource>();
        m_Animator = parentObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ColliderCheck.IsTouching(Detect) && Dissappear.activeSelf)
        {
            audioData.Play(0);
            m_Animator.SetTrigger(Trigger);
            Dissappear.SetActive(false);
            Appear.SetActive(true);

        }
    }
}
