using Player.Factories;

namespace Player.States
{
    public sealed class HitState : BaseState
    {
        public HitState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}