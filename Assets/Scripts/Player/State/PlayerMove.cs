using Player.Enum;
using UnityEngine;

namespace Player.State
{
    public sealed class PlayerMove : PlayerState
    {
        private float Speed => (Context.Input.HasPressedSprint)
            ? RunSpeed
            : WalkSpeed;

        private const float WalkSpeed = 7.0f;
        private const float RunSpeed = 12.0f;

        public PlayerMove(PlayerStateMachine context, PlayerStateEnum name) : base(context, name) { }

        public override void OnStateUpdate()
        {
            Movement();
        }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.Entity.Health.HasDied())
            {
                return PlayerStateEnum.Death;
            }

            if (Context.Input.HasPressedAttack)
            {
                return PlayerStateEnum.Attack;
            }

            if (Context.Input.HasPressedDash)
            {
                return PlayerStateEnum.Dash;
            }

            return PlayerStateEnum.Move;
        }

        private void Movement()
        {
            var movementDirection = Context.Input.Direction.normalized;

            Context.rigidbody.velocity = movementDirection * Speed;
        }
    }
}