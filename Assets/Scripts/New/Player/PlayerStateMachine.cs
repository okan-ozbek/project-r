using System.Collections.Generic;
using Component;
using New.Enums;
using New.Player.States;
using New.State_Machine;
using Player.Component;
using UnityEngine;

namespace New.Player
{
    public class PlayerStateMachine : GenericFiniteStateMachine<PlayerStatesEnum>
    {
        [SerializeField] private float healthAmount = 100;
        
        [HideInInspector] public new Rigidbody rigidbody;
        [HideInInspector] public BoxCollider boxCollider;

        [HideInInspector] public PlayerInput Input;
        [HideInInspector] public Entity Entity;
    
        private void Start()
        {
            SetComponents();
            SetStates(PlayerStatesEnum.Move);
        }

        private void Update()
        {
            Input.Update();
        }
    
        protected override Dictionary<PlayerStatesEnum, GenericBaseState<PlayerStatesEnum>> GetStates()
        {
            return new Dictionary<PlayerStatesEnum, GenericBaseState<PlayerStatesEnum>>()
            {
                { PlayerStatesEnum.Attack, new PlayerAttackState(this) },
                { PlayerStatesEnum.Dash, new PlayerDashState(this) },
                { PlayerStatesEnum.Hit, new PlayerHitState(this) },
                { PlayerStatesEnum.Move, new PlayerMoveState(this) },
            };
        }

        private void SetComponents()
        {
            rigidbody = GetComponent<Rigidbody>();
            boxCollider = GetComponent<BoxCollider>();
        
            Input = new PlayerInput();
            Entity = new Entity(new Health(healthAmount));
        }
    }
}