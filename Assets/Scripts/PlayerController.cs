using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    
    [Space]
    [Header("Player Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private int maxJumpCombo;
    [SerializeField] private List<AudioSource> sounds;

    [Header("Player State")]
    private int jumpCombo;
    private bool isGrounded;
    public bool isSideColliding;
    private string wallSide;


    private void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);
        animator.SetFloat("Run", Mathf.Abs(directionX));
        animator.SetFloat("velocityY", rb.velocity.y);

        if (directionX == 1) transform.localScale = new Vector2(1, 1);
        else if(directionX == -1) transform.localScale = new Vector2(-1, 1);

  
        if (isGrounded) jumpCombo = 0;

        if (Input.GetKeyDown(KeyCode.Space) && jumpCombo < maxJumpCombo && !isSideColliding)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            jumpCombo++;
            animator.SetInteger("jumpCombo", jumpCombo);
            sounds[0].Play();

        }

        if(isSideColliding && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);

            rb.AddForce(new Vector2(0, jumpForce));

            isGrounded = false;
            animator.SetInteger("jumpCombo", jumpCombo);
            sounds[0].Play();
        }
    }

    public void setGroundedState(bool e)
    {
        isGrounded = e;
        animator.SetBool("isJumping", !e);
    }

    public void setSideColliding(bool e, string side)
    {
        isSideColliding = e;
        wallSide = side;
        animator.SetBool("isInWall", e);
    }
}
