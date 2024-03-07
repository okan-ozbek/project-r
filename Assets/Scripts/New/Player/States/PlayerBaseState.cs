using New.Enums;
using New.State_Machine;

namespace New.Player.States
{
    public abstract class PlayerBaseState : GenericBaseState<PlayerStatesEnum>
    {
        protected readonly PlayerStateMachine Context;

        protected PlayerBaseState(PlayerStatesEnum key, PlayerStateMachine context) : base(key)
        {
            Context = context;
        }
    
        public abstract override void CheckStateSwitch();
    }
}