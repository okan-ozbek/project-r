using System.Collections.Generic;
using Component;
using Enums;
using Player.Components;
using Player.States;
using State_Machine;
using UnityEngine;

namespace Player
{
    public class PlayerStateMachine : GenericFiniteStateMachine<PlayerStatesEnum>
    {
        [SerializeField] private float healthAmount = 100;
        
        [HideInInspector] public new Rigidbody rigidbody;
        [HideInInspector] public BoxCollider boxCollider;
        
        public PlayerInput PlayerInput;
        public Entity Entity;
    
        private void Start()
        {
            PlayerInput = new PlayerInput();
            
            SetComponents();
            SetStates(PlayerStatesEnum.Move);
        }

        private void Update()
        {
            PlayerInput.Update();
            CurrentState.Update();
        }
    
        protected override Dictionary<PlayerStatesEnum, GenericBaseState<PlayerStatesEnum>> GetStates()
        {
            return new Dictionary<PlayerStatesEnum, GenericBaseState<PlayerStatesEnum>>
            {
                { PlayerStatesEnum.Attack, new PlayerAttackState(this) },
                { PlayerStatesEnum.Dash, new PlayerDashState(this) },
                { PlayerStatesEnum.Hit, new PlayerHitState(this) },
                { PlayerStatesEnum.Move, new PlayerMoveState(this) }
            };
        }

        private void SetComponents()
        {
            rigidbody = GetComponent<Rigidbody>();
            boxCollider = GetComponent<BoxCollider>();
        
            Entity = new Entity(new Health(healthAmount));
        }
    }
}