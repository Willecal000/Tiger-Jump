using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float JumpHeight;

    private Rigidbody2D rb2d;

    private float _movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         rb2d.linearVelocityX = _movement;
    }

    public void Move(InputAction.CallbackContext ctx) 
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
    }

    public void Jump(InputAction.CallbackContext ctx) // a public void is a function/method which is a piece of code where we put more pieces of code to code
    {
        if (ctx.ReadValue<float>() == 1)
        {
            rb2d.linearVelocityY = JumpHeight;
        }
    }

}
