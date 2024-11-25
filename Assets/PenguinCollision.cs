using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag; // Tag that triggers destruction

    private void OnTriggerEnter2D(Collider2D other) {
        // Destroy this object and the other object if the tags match
        if (other.CompareTag(triggeringTag) && enabled) {
            Destroy(this.gameObject); // Destroy the penguin
            Destroy(other.gameObject); // Destroy the car or truck
        }
    }

    private void Update() {
        
    }
}
