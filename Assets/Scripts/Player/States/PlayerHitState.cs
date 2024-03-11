using Enums;
using Player.States;

namespace Player.States
{
    public class PlayerHitState : PlayerBaseState
    {
        public PlayerHitState(PlayerStateMachine context) : base(PlayerStatesEnum.Hit, context) { }

        protected override void CheckStateSwitch()
        {
            // Context.TransitionTo(TestStates.Test002);
        }
    }
}