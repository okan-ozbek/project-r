using Enums;
using UnityEngine;

namespace Player.States
{
    public class PlayerMoveState : PlayerBaseState
    {
        private float Speed => Context.PlayerInput.HasPressedSprint
            ? MaxRunSpeed
            : MaxWalkSpeed;
        
        private const float MaxWalkSpeed = 7.0f;
        private const float MaxRunSpeed = 12.0f;

        private const float AccelerationSpeed = 0.5f;
        private const float DecelerationSpeed = 1.2f;
        
        public PlayerMoveState(PlayerStateMachine context) : base(PlayerStatesEnum.Move, context) { }

        public override void OnUpdate()
        {
            Acceleration();
            Deceleration();
        }

        protected override void CheckStateSwitch()
        {
            if (Context.Entity.Health.HasDied())
            {
                Context.TransitionTo(PlayerStatesEnum.Death);
            }

            if (Context.PlayerInput.HasPressedAttack)
            {
                Context.TransitionTo(PlayerStatesEnum.Attack);
            }

            if (Context.PlayerInput.HasPressedDash)
            {
                Context.TransitionTo(PlayerStatesEnum.Dash);
            }
        }
        
        private void Acceleration()
        {
            var movementDirection = Context.PlayerInput.Direction.normalized;

            Context.rigidbody.velocity += movementDirection * AccelerationSpeed;
            Context.rigidbody.velocity = GetMinVelocity();
        }

        private void Deceleration()
        {
            if (Context.PlayerInput.Direction != Vector3.zero) 
                return;
            
            Context.rigidbody.velocity -= Vector3.one * DecelerationSpeed;
            Context.rigidbody.velocity = GetMaxVelocity();
        }

        private Vector3 GetMinVelocity()
        {
            return new Vector3(
                Mathf.Min(Context.rigidbody.velocity.x, Speed),
                0.0f,
                Mathf.Min(Context.rigidbody.velocity.z, Speed)
            );
        }

        private Vector3 GetMaxVelocity()
        {
            return new Vector3(
                Mathf.Max(Context.rigidbody.velocity.x, 0.0f),
                0.0f,
                Mathf.Max(Context.rigidbody.velocity.z, 0.0f)
            );
        }
    }
}