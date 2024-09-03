using UnityEngine;

public class SpawnOnEdgeComponent : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(10, Random.Range(-3.5f,3.5f), 0);
    }
}
