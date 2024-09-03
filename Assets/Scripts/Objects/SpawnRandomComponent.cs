using UnityEngine;

public class SpawnRandomComponent : MonoBehaviour
{
    void Start()
    {
        transform.position = Random.insideUnitCircle * 3; 
    }
}

