using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;

    void Awake()
    {
        animator = GetComponent<Animator>();    
        rb =  GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.linearVelocityY < 0)
        {
            animator.SetBool("Falling", true);
            animator.SetBool("Jumping", false);
        }
        if (rb.linearVelocityY >= 0)
        {
            animator.SetBool("OnGround", true);
            animator.SetBool("Falling", false);
        }
    }
    
    public void OnMove()
    {
        animator.SetBool("Moving", true);
    }

    public void OnJump()
    {
        animator.SetBool("Jumping", true);
        animator.SetBool("Falling", false);
    }
}
