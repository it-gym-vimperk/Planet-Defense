using UnityEngine;

public class Pulsate : MonoBehaviour
{
    private void Update()
    {
        transform.localScale = new Vector3(1 + Mathf.Sin(Time.time * 5) * 0.2f, 1 + Mathf.Sin(Time.time * 5) * 0.2f, 1);
    }
}
