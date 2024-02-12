using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        public float accelerationSpeed;

        private Rigidbody _rigidbody;

        private void Start()
        {
        }
        
        private void Update()
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
            input.Normalize();

            transform.Translate(input * accelerationSpeed * Time.deltaTime);
        }
    }
}
