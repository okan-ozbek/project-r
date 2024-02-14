using Player.Factories;

namespace Player.States
{
    public sealed class JumpState : BaseState
    {
        public JumpState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}