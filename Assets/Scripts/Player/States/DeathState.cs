using Player.Factories;

namespace Player.States
{
    public sealed class DeathState : BaseState
    {
        public DeathState(PlayerContext context, PlayerStateFactory factory) : base(context, factory)
        {
        }

        protected override void CheckStateTransitionable()
        {
            throw new System.NotImplementedException();
        }
    }
}