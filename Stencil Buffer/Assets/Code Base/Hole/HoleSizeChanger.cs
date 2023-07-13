using UnityEngine;

namespace Code_Base.Hole
{
    public class HoleSizeChanger : MonoBehaviour
    {
        [SerializeField] private float _amplitude = 1f;
        [SerializeField] private float _frequency = 2f;
        
        private void Update()
        {
            transform.localScale = new Vector3(Mathf.Sin(Time.time * _frequency) * _amplitude, transform.localScale.y,
                Mathf.Sin(Time.time * _frequency) * _amplitude );
        }
    }
}
