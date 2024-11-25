using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the truck

    void Update()
    {
        // Move the truck to the right
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    // Destroy the truck if it moves too far off-screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
