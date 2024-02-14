using System.Collections.Generic;
using Player.Enums;
using Player.States;

namespace Player.Factories
{
    public sealed class PlayerStateFactory
    {
        private readonly Dictionary<PlayerStateEnum, BaseState> _states;

        public PlayerStateFactory(PlayerContext context)
        {
            _states = new Dictionary<PlayerStateEnum, BaseState>
            {
                { PlayerStateEnum.Attack, new AttackState(context, this) },
                { PlayerStateEnum.Death, new DeathState(context, this) },
                { PlayerStateEnum.Fall, new FallState(context, this) },
                { PlayerStateEnum.Grounded, new GroundedState(context, this) },
                { PlayerStateEnum.Hit, new HitState(context, this) },
                { PlayerStateEnum.Jump, new JumpState(context, this) }
            };
        }

        public BaseState Attack()
        {
            return _states[PlayerStateEnum.Attack];
        }
        
        public BaseState Death()
        {
            return _states[PlayerStateEnum.Death];
        }
        
        public BaseState Fall()
        {
            return _states[PlayerStateEnum.Fall];
        }
        
        public BaseState Grounded()
        {
            return _states[PlayerStateEnum.Grounded];
        }
        
        public BaseState Hit()
        {
            return _states[PlayerStateEnum.Hit];
        }
        
        public BaseState Jump()
        {
            return _states[PlayerStateEnum.Jump];
        }
    }
}