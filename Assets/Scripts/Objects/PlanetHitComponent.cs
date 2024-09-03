using UnityEngine;

public class PlanetHitComponent : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Planet"))
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            GameManager.Instance.GameOver();
        }
    }
}
