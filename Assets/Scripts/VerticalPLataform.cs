using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPLataform : MonoBehaviour
{
    private PlatformEffector2D effector;
    private float waitTime;
    [SerializeField] private float waitTimeValue = 0.2f;

    private void Awake()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.S)) waitTime = waitTimeValue;

        if (Input.GetKey(KeyCode.S))
        {
            if(waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = waitTimeValue;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.Space)) effector.rotationalOffset = 0f; 
        
    }
}
