using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementB : MonoBehaviour
{
    float speedBX = 0;
    float speedBY = 0;
    float speedBZ = 1;
    void Update()
    {
        transform.position += new Vector3(speedBX, speedBY, speedBZ) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision other)
    {
       speedBZ = speedBZ * 0; 
    }
}
