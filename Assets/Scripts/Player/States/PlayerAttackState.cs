using Enums;

namespace Player.States
{
    public class PlayerAttackState : PlayerBaseState
    {
        public PlayerAttackState(PlayerStateMachine context) : base(PlayerStatesEnum.Attack, context) { }

        protected override void CheckStateSwitch()
        {
            // Context.TransitionTo(TestStates.Test002);
        }
    }
}