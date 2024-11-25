using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoinOnTouch : MonoBehaviour
{
    [Tooltip("The tag of the object that can destroy the coin")]
    [SerializeField] private string triggeringTag = "Penguin"; // Default tag for the penguin

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object touching the coin has the triggering tag
        if (other.CompareTag(triggeringTag))
        {
            Destroy(gameObject); // Destroy the coin
        }
    }
}
