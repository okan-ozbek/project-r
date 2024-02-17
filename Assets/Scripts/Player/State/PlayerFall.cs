using Player.Enum;

namespace Player.State
{
    public sealed class PlayerFall : PlayerState
    {
        public PlayerFall(PlayerStateMachine context, PlayerStateEnum name) : base(context, name)
        {
        }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.OnGround())
            {
                return PlayerStateEnum.Grounded;
            }

            return PlayerStateEnum.Fall;
        }
    }
}