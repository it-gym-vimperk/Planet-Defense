using UnityEngine;

public class StraightMoveComponent : MonoBehaviour
{
    [SerializeField] float speed = 3;
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}