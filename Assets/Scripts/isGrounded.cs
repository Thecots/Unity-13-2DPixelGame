using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{

    [SerializeField] private PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TileMap")  playerController.setGroundedState(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "TileMap")  playerController.setGroundedState(false);
    }
}
