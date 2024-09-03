using UnityEngine;

public class InstantiateOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject prefabToInstantiate;

    private void OnDestroy()
    {
        Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
    }
}