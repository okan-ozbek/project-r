using Player.Factories;
using Player.States;
using UnityEngine;

namespace Player
{
    public sealed class PlayerContext : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; private set; }

        private BaseState _state;
        private PlayerStateFactory _factory;
        
        private void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
            
            _factory = new PlayerStateFactory(this);
            _state.Init(_factory.Fall());
        }

        private void Update()
        {
            _state.Update();
        }

        private void FixedUpdate()
        {
            _state.FixedUpdate();
        }
    }
}