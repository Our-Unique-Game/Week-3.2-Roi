using UnityEngine;

public class TruckCollision : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] private string triggeringTag = "Penguin"; // Default tag for the penguin
    [Tooltip("Explosion effect prefab to instantiate when the truck collides")]
    [SerializeField] private GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the truck collides with the penguin
        if (other.CompareTag(triggeringTag))
        {
            // Spawn the explosion effect at the truck's position
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }

            // Destroy both the truck and the penguin
            Destroy(this.gameObject); // Destroy the truck
            Destroy(other.gameObject); // Destroy the penguin
        }
    }
}
