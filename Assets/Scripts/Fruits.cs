using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    [SerializeField] private gameManager gm;

    private Animator animator;
    private bool isAudioPlayed;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            animator.SetBool("Collected", true);
            if (!isAudioPlayed)
            {
                sound.Play();
                isAudioPlayed = true;
                gm.AddScore();


            }
            Destroy(gameObject, 0.2f);
        }
        
    }
}
