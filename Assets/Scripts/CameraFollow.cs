using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] List<Vector3> positions;

    private void Awake()
    {
        transform.position = positions[0];

    }
    public void TransitionTo(int e)
    {
        Debug.Log(1213);
        transform.position = positions[e];
    }
}
