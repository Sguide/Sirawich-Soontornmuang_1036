using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementA : MonoBehaviour
{
    float speedAX = 1;
    float speedAY = 0;
    float speedAZ = 0; 
    void Update()
    {
        transform.position += new Vector3(speedAX, speedAY, speedAZ) * Time.deltaTime;
    }
    void OnCollision(Collision other)
    {
        speedAX = speedAX * 0;
    }
}
