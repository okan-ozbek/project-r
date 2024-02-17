using Player.Enum;

namespace Player.State
{
    public class PlayerAttack : PlayerState
    {
        public PlayerAttack(PlayerStateMachine context, PlayerStateEnum name) : base(context, name) { }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.Entity.Health.HasDied())
            {
                return PlayerStateEnum.Death;
            }
            
            return PlayerStateEnum.Attack;        
        }
    }
}