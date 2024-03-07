using New.Enums;
using UnityEngine;

namespace New.Player.States
{
    public class PlayerMoveState : PlayerBaseState
    {
        private float Speed => (Context.Input.HasPressedSprint)
            ? MaxRunSpeed
            : MaxWalkSpeed;
        
        private const float MaxWalkSpeed = 7.0f;
        private const float MaxRunSpeed = 12.0f;

        private const float AccelerationSpeed = 0.5f;
        private const float DecelerationSpeed = 1.2f;
        
        public PlayerMoveState(PlayerStateMachine context) : base(PlayerStatesEnum.Move, context) { }

        public override void Update()
        {
            base.Update();

            Acceleration();
            Deceleration();
        }

        public override void CheckStateSwitch()
        {
            if (Context.Entity.Health.HasDied())
            {
                Context.TransitionTo(PlayerStatesEnum.Death);
            }

            if (Context.Input.HasPressedAttack)
            {
                Context.TransitionTo(PlayerStatesEnum.Attack);
            }

            if (Context.Input.HasPressedDash)
            {
                Context.TransitionTo(PlayerStatesEnum.Dash);
            }
        }
        
        private void Acceleration()
        {
            var movementDirection = Context.Input.Direction.normalized;

            Context.rigidbody.velocity += movementDirection * AccelerationSpeed;
            Context.rigidbody.velocity = GetMinVelocity();
        }

        private void Deceleration()
        {
            if (Context.Input.Direction == Vector3.zero)
            {
                Context.rigidbody.velocity -= Vector3.one * DecelerationSpeed;
                Context.rigidbody.velocity = GetMaxVelocity();
            }
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