using System.Collections;
using UnityEngine;

public class CannonComponent : MonoBehaviour
{
    [SerializeField] private float interval = 5;
    [SerializeField] private GameObject bulletPrefab;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(interval);
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}