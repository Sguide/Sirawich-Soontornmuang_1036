using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementB : MonoBehaviour
{
    float speedaX = -1;
    float speedaY = 0;
    float speedaZ = 0;
    void Update()
    {
        transform.position += new Vector3(speedaX, speedaY, speedaZ) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision other)
    {
        speedaX = speedaX * 0;
    }
}
