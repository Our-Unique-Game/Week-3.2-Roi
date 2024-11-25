using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = -5f; // Speed of the car

    void Update()
    {
        // Move the car forward
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    // Destroy the car if it moves too far off-screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
