using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefSideColliding : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TileMap")  playerController.setSideColliding(true, "left");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "TileMap")  playerController.setSideColliding(false, "left");

    }
}
