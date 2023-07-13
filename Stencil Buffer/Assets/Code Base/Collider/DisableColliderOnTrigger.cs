using UnityEngine;

namespace Code_Base.Collider
{
    public class DisableColliderOnTrigger : MonoBehaviour
    {
        [SerializeField] private UnityEngine.Collider _playerCollider;
        [SerializeField] private Rigidbody _playerRigidbody;
        private CharacterController _characterController;
        
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            if ( other != _playerCollider)
                return;

            _playerCollider.enabled = false;
            _playerRigidbody.isKinematic = false;
        }

        private void OnTriggerExit(UnityEngine.Collider other)
        {
            if ( other != _playerCollider)
                return;

            _playerCollider.enabled = true;
        }
    }
}
