using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float JumpHeight;
    Animator m_Animator;
    public Rigidbody2D rb2d;
    public GameObject GO;

    private float _movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        m_Animator = GO.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.linearVelocityX = _movement;
        if (rb2d.linearVelocityX > 0 || rb2d.linearVelocityX < 0)
        { 
            m_Animator.SetBool("Running", true);
        }
        else
        {
            m_Animator.SetBool("Running", false);
        }
    }

    public void Move(InputAction.CallbackContext ctx) 
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
    }

    public void Jump(InputAction.CallbackContext ctx) // a public void is a function/method which is a piece of code where we put more pieces of code to code
    {
        m_Animator.SetTrigger("Jump");
        if (ctx.ReadValue<float>() == 1)
        {
            
            rb2d.linearVelocityY = JumpHeight;
        }
    }

}
