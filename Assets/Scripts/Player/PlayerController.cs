using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        public float accelerationSpeed;
        public float decelerationSpeed;
        public float maxAccelerationSpeed;
        
        private Vector3 _velocity;
        
        private Rigidbody _rigidbody;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        private void Update()
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
            input.Normalize();

            if (input != Vector3.zero)
            {
                _velocity += new Vector3(
                    Mathf.Min(input.x * accelerationSpeed * Time.deltaTime, maxAccelerationSpeed), 
                    0.0f,
                    Mathf.Min(input.z * accelerationSpeed * Time.deltaTime, maxAccelerationSpeed)
                );
            }
            else
            {
                _velocity -= new Vector3(
                    Mathf.Max(_velocity.x - decelerationSpeed * Time.deltaTime, 0.0f),
                    0.0f,
                    Mathf.Max(_velocity.z - decelerationSpeed * Time.deltaTime, 0.0f)
                );
            }

            _rigidbody.velocity = _velocity;
        }
    }
}
