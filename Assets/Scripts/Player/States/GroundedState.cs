using Player.Factories;

namespace Player.States
{
    public sealed class GroundedState : BaseState
    {
        public GroundedState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}