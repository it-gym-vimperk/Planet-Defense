using UnityEngine;

public class DestroyByTapComponent : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        GameManager.Instance.IncreaseScore();
    }
}