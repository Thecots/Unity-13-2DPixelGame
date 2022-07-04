using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Animator animator;
    private AudioSource sound;
    private bool isAudioPlayed = false;
    [SerializeField] private float jumpForce = 700f;
    [SerializeField] private Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            animator.SetBool("Destroy", true);
            rb.AddForce(new Vector2(0, jumpForce));

            if (!isAudioPlayed)
            {
                sound.Play();
                isAudioPlayed = true;
            }

            Destroy(gameObject, 0.2f);
        }
    }
}
