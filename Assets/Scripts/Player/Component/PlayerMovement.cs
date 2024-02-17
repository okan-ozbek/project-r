using UnityEngine;

namespace Player.Component
{
    public sealed class PlayerMovement
    {
        private PlayerStateMachine _context;
        
        public PlayerMovement(PlayerStateMachine context)
        {
            _context = context;
        }

        public void Update()
        {
            _context.rigidbody.velocity = _context.Input.Direction * _context.Speed;
        }
    }
}