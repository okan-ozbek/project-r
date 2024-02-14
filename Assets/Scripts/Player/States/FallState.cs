using Player.Factories;

namespace Player.States
{
    public sealed class FallState : BaseState
    {
        public FallState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}