using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPig : MonoBehaviour
{
    [SerializeField] private GameObject pig;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Player")
        {
            animator.SetBool("hit", true);
            sound.Play();
            rb.AddForce(new Vector2(0, 450f));
            Destroy(pig, 0.2f);
        }
    }
}
