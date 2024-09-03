using UnityEngine;

public class DestroyableByBombComponent : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bomb"))
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
    }
}