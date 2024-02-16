using Player.Factories;

namespace Player.States
{
    public sealed class AttackState : BaseState
    {
        public AttackState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}