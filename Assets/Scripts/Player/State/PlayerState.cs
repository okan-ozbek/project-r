using Player.Enum;
using StateMachine;

namespace Player.State
{
    public abstract class PlayerState : BaseState<PlayerStateEnum>
    {
        protected readonly PlayerStateMachine Context;

        protected PlayerState(PlayerStateMachine context, PlayerStateEnum name) : base(name)
        {
            Context = context;
        }
    }
}