using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    [SerializeField] private CameraFollow cam;
    [SerializeField] private int sceneValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cam.TransitionTo(sceneValue);

    }
}
