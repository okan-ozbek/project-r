using New.Enums;

namespace New.Player.States
{
    public class PlayerDashState : PlayerBaseState
    {
        public PlayerDashState(PlayerStateMachine context) : base(PlayerStatesEnum.Dash, context) { }

        public override void CheckStateSwitch()
        {
            // Context.TransitionTo(TestStates.Test002);
        }
    }
}