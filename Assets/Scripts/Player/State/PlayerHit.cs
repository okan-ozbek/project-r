using Player.Enum;

namespace Player.State
{
    public class PlayerHit : PlayerState
    {
        private bool _isInAnimation;
        
        public PlayerHit(PlayerStateMachine context, PlayerStateEnum name) : base(context, name) { }

        public override void OnStateEnter()
        {
            _isInAnimation = true;
        }

        public override void OnStateUpdate()
        {
            // TODO add the hit animation here
        }

        public override void OnStateLeave()
        {
            _isInAnimation = false;
        }

        public override PlayerStateEnum GetNewState()
        {
            if (Context.Entity.Health.HasDied())
            {
                return PlayerStateEnum.Death;
            }
            
            if (AnimationFinished())
            {
                return PlayerStateEnum.Move;
            }

            return PlayerStateEnum.Hit;
        }

        private bool AnimationFinished()
        {
            return (!_isInAnimation);
        }
    }
}