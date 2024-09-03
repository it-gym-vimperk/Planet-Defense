using UnityEngine;

public class RandomStraightMoveComponent : MonoBehaviour
{
    [SerializeField] float Speed = 3;
    float actualSpeed;

    void Start()
    {
        actualSpeed = Random.Range(Speed - Speed * 0.5f, Speed + Speed * 0.5f);
    }
    void Update()
    {
        transform.position += new Vector3(-actualSpeed * Time.deltaTime, 0, 0);
    }
}