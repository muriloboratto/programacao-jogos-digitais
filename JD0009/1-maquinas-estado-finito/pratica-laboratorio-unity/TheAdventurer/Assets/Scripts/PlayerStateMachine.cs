using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class PlayerStateMachine : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float jumpYVelocity = 8f;
    [SerializeField] float runXVelocity = 4f;
    [SerializeField] float raycastDistance = 0.7f;
    [SerializeField] LayerMask collisionMask;

    Animator animator;
    Rigidbody2D physics;
    SpriteRenderer sprite;

    enum State { Idle, Run, Jump, Glide }

    State state = State.Idle;
    bool isGrounded = false;
    bool jumpInput = false;

    float horizontalInput = 0f;

    void FixedUpdate()
    {
        // get player input
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, collisionMask).collider != null;
        jumpInput = Input.GetKey(KeyCode.Space);
        horizontalInput = Input.GetAxisRaw("Horizontal");

        // flip sprite based on horizontal input
        if (horizontalInput > 0f)
        {
            sprite.flipX = false;
        }
        else if (horizontalInput < 0f)
        {
            sprite.flipX = true;
        }

        // run current state
        switch (state)
        {
            case State.Idle: IdleState(); break;
            case State.Run: RunState(); break;
            case State.Jump: JumpState(); break;
            case State.Glide: GlideState(); break;
        }
    }

    void IdleState()
    {
        // actions
        animator.Play("Idle");

        // transitions
        if (isGrounded)
        {
            if (jumpInput)
            {
                state = State.Jump;
            }
            else if (horizontalInput != 0f)
            {
                state = State.Run;
            }
        }
    }

    void RunState()
    {
        // actions
        animator.Play("Run");
        physics.velocity = runXVelocity * horizontalInput * Vector2.right;

        // transitions
        if (isGrounded && jumpInput)
        {
            state = State.Jump;
        }
        else if (horizontalInput == 0f)
        {
            state = State.Idle;
        }
    }

    void JumpState()
    {
        // actions
        animator.Play("Jump");
        physics.velocity = runXVelocity * horizontalInput * Vector2.right + jumpYVelocity * Vector2.up;

        // transitions
        state = State.Glide;

    }

    void GlideState()
    {
        // actions
        if (physics.velocity.y > 0f)
        {
            animator.Play("Jump");
        }
        else
        {
            animator.Play("Fall");
        }

        physics.velocity = physics.velocity.y * Vector2.up + runXVelocity * horizontalInput * Vector2.right;

        // transitions
        if (isGrounded)
        {
            if (horizontalInput != 0f)
            {
                state = State.Run;
            }
            else
            {
                state = State.Idle;
            }
        }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        physics = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
}
