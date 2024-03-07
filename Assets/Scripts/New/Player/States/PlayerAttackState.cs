using New.Enums;

namespace New.Player.States
{
    public class PlayerAttackState : PlayerBaseState
    {
        public PlayerAttackState(PlayerStateMachine context) : base(PlayerStatesEnum.Attack, context) { }

        public override void CheckStateSwitch()
        {
            // Context.TransitionTo(TestStates.Test002);
        }
    }
}