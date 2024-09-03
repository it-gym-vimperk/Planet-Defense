    using UnityEngine;

    public class DestroyIn : MonoBehaviour
    {
        [SerializeField] float destroyDelay = 1.0f;
        private void Awake()
        {
            Destroy(gameObject, destroyDelay);
        }
    }
    
