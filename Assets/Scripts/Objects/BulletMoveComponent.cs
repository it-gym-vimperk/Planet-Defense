using UnityEngine;

public class BulletMoveComponent : MonoBehaviour
{
    [SerializeField] float Speed = 3;
    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
    }
}