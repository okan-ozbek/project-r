using Enums;
using State_Machine;

namespace Player.States
{
    public abstract class PlayerBaseState : GenericBaseState<PlayerStatesEnum>
    {
        protected readonly PlayerStateMachine Context;

        protected PlayerBaseState(PlayerStatesEnum key, PlayerStateMachine context) : base(key)
        {
            Context = context;
        }

        protected abstract override void CheckStateSwitch();
    }
}