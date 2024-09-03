using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    private void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
