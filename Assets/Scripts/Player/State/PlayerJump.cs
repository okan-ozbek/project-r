using Player.Enum;

namespace Player.State
{
    public class PlayerJump : PlayerState
    {
        public PlayerJump(PlayerStateMachine context, PlayerStateEnum name) : base(context, name)
        {
        }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.OnGround())
            {
                return PlayerStateEnum.Grounded;
            }

            return PlayerStateEnum.Jump;
        }
    }
}