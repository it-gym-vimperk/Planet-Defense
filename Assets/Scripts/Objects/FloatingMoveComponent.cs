using UnityEngine;

public class FloatingMoveComponent : MonoBehaviour
{
    [SerializeField] float Speed = 3;
    float actualSpeed;
    float rndTime;
 
    void Start()
    {
        actualSpeed = Random.Range(Speed - Speed * 0.5f, Speed + Speed * 0.5f);
        rndTime = Random.Range(0, 10);
    }
    void Update()
    {
        transform.position += new Vector3(-actualSpeed * Time.deltaTime,  Mathf.Sin(rndTime + Time.time * 4) * 0.5f / 10, 0);
    }
}