using New.Enums;

namespace New.Player.States
{
    public class PlayerHitState : PlayerBaseState
    {
        public PlayerHitState(PlayerStateMachine context) : base(PlayerStatesEnum.Hit, context) { }

        public override void CheckStateSwitch()
        {
            // Context.TransitionTo(TestStates.Test002);
        }
    }
}