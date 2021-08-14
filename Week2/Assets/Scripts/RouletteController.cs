using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10.0f;
        }

        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.96f;
    }
}
