using Player.Enum;

namespace Player.State
{
    public class PlayerGrounded : PlayerState
    {
        public PlayerGrounded(PlayerStateMachine context, PlayerStateEnum name) : base(context, name)
        {
        }

        public override void OnStateUpdate()
        {
            Context.Movement.Update();
        }

        public override PlayerStateEnum GetNewState()
        {
            return PlayerStateEnum.Grounded;        
        }
    }
}