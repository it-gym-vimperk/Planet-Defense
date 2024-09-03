using UnityEngine;

public class DuplicateByTapComponent : MonoBehaviour
{
    [SerializeField] GameObject duplicationPrefab;

    void OnMouseDown()
    {
        Instantiate(duplicationPrefab, transform.position + Vector3.up, Quaternion.identity);
        Instantiate(duplicationPrefab, transform.position + Vector3.down, Quaternion.identity);
    }
}
