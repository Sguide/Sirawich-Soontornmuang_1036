using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementB2 : MonoBehaviour
{
    float speedbX = 0;
    float speedbY = 0;
    float speedbZ = -1;
    void Update()
    {
        translate.position += new Vector3(speedbX, speedbY, speedbZ) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision other)
    {
        speedbZ = speedbZ * 0;
    }
}
