using System;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class KowalskiStateMachine : MonoBehaviour
{
    public int Bullets => bullets;
    public int MaxBullets => maxBullets;

    [Header("Settings")]
    [SerializeField] float jumpYVelocity = 8f;
    [SerializeField] float runXVelocity = 4f;
    [SerializeField] float raycastDistance = 0.1f;
    [SerializeField] int maxBullets = 30;
    [SerializeField] LayerMask collisionMask;

    Animator animator;
    Rigidbody2D physics;
    SpriteRenderer sprite;

    enum State { Idle, Run, Shoot, Reload, Jump, BellyIdle, BellyShoot, BatAttack }

    State currentState = State.Idle;
    bool jumpInput = false;
    bool shootInput = false;
    bool reloadInput = false;
    bool bellyInput = false;
    bool batAttackInput = false;
    bool isGrounded = false;
    bool canShoot = false;
    float horizontalInput = 0f;
    int bullets = 30;

    void FixedUpdate()
    {
        // get player input
        jumpInput = Input.GetKey(KeyCode.W);
        shootInput = Input.GetKey(KeyCode.Space);
        reloadInput = Input.GetKey(KeyCode.R);
        bellyInput = Input.GetKey(KeyCode.S);
        batAttackInput = Input.GetKey(KeyCode.E);
        horizontalInput = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, collisionMask).collider != null;
        canShoot = bullets > 0;

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
        switch (currentState)
        {
            case State.Idle: IdleState(); break;
            case State.Run: RunState(); break;
            case State.Shoot: ShootState(); break;
            case State.Reload: ReloadState(); break;
            case State.Jump: JumpState(); break;
            case State.BellyIdle: BellyIdleState(); break;
            case State.BellyShoot: BellyShootState(); break;
            case State.BatAttack: BatAttackState(); break;
        }
    }

    private void BatAttackState()
    {
        // actions
        animator.Play("BatAttack");

        // no transitions
        // wait for animation event to signal that the character has finished reloading
    }

    void BellyIdleState()
    {
        // actions
        animator.Play("Belly");

        // transitions
        if (isGrounded)
        {
            if (bellyInput)
            {
                if (shootInput && canShoot)
                {
                    currentState = State.BellyShoot;
                }
            }
            else
            {
                currentState = State.Idle;
            }
        }
    }

    void IdleState()
    {
        // actions
        animator.Play("Idle");

        // transitions
        if (isGrounded)
        {
            if (shootInput && canShoot)
            {
                currentState = State.Shoot;
            }
            else if (batAttackInput)
            {
                currentState = State.BatAttack;
            }
            else if (jumpInput)
            {
                currentState = State.Jump;
                physics.velocity = runXVelocity * horizontalInput * Vector2.right + jumpYVelocity * Vector2.up;
            }
            else if (reloadInput)
            {
                currentState = State.Reload;
            }
            else if (horizontalInput != 0f)
            {
                currentState = State.Run;
            }
            else if (bellyInput)
            {
                currentState = State.BellyIdle;
            }
        }
        else
        {
            currentState = State.Jump;
        }
    }

    void BellyShootState()
    {
        // actions
        animator.Play("BellyShoot");

        // transitions
        if (!shootInput || !canShoot || !bellyInput)
        {
            currentState = State.BellyIdle;
        }
    }

    void ShootState()
    {
        // actions
        animator.Play("Shoot");

        // transitions
        if (jumpInput)
        {
            currentState = State.Jump;
            physics.velocity = runXVelocity * horizontalInput * Vector2.right + jumpYVelocity * Vector2.up;
        }
        else if (!shootInput || !canShoot)
        {
            currentState = State.Idle;
        }
    }

    void ReloadState()
    {
        // actions
        animator.Play("Reload");

        // no transitions
        // wait for animation event to signal that the character has finished reloading
    }

    void RunState()
    {
        // actions
        animator.Play("Run");
        physics.velocity = runXVelocity * horizontalInput * Vector2.right;

        // transitions
        if (isGrounded && jumpInput)
        {
            currentState = State.Jump;
            physics.velocity = runXVelocity * horizontalInput * Vector2.right + jumpYVelocity * Vector2.up;
        }
        else if (horizontalInput == 0f)
        {
            currentState = State.Idle;
        }
    }

    void JumpState()
    {
        // actions
        animator.Play("Jump");

        // transitions
        if (isGrounded)
        {
            currentState = State.Idle;
        }
    }

    // called from the animation event on the Shoot animation
    void FireBullet()
    {
        bullets = Mathf.Max(0, bullets - 1);
    }

    // called from the animation event on the Reload animation
    void FinishReload()
    {
        bullets = maxBullets;
        currentState = State.Idle;
    }

    // called from the animation event on the BatAttack animation
    void FinishBatAttack()
    {
        currentState = State.Idle;
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        physics = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
}
