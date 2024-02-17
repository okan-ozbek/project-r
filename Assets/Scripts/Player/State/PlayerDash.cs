using Player.Enum;

namespace Player.State
{
    public class PlayerDash : PlayerState
    {
        public PlayerDash(PlayerStateMachine context, PlayerStateEnum name) : base(context, name) { }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.Entity.Health.HasDied())
            {
                return PlayerStateEnum.Death;
            }
            
            return PlayerStateEnum.Dash;        
        }
    }
}