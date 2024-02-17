using Component;
using Player.Component;
using Player.Enum;
using Player.State;
using StateMachine;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
    public sealed class PlayerStateMachine : StateManager<PlayerStateEnum>
    {
        [SerializeField] private float healthAmount;
        
        [HideInInspector] public new Rigidbody rigidbody;
        [HideInInspector] public BoxCollider boxCollider;

        [HideInInspector] public PlayerInput Input;
        [HideInInspector] public Entity Entity;

        protected override void Start()
        {
            InitializeComponents();
            
            base.Start();
        }

        protected override void Update()
        {
            Input.Update();
            
            base.Update();
        }

        protected override void InitializeStates()
        {
            States.Add(PlayerStateEnum.Move, new PlayerMove(this, PlayerStateEnum.Move));
            States.Add(PlayerStateEnum.Dash, new PlayerDash(this, PlayerStateEnum.Dash));
            States.Add(PlayerStateEnum.Attack, new PlayerAttack(this, PlayerStateEnum.Attack));
            
            CurrentState = States[PlayerStateEnum.Move];
        }

        private void InitializeComponents()
        {
            rigidbody = GetComponent<Rigidbody>();
            boxCollider = GetComponent<BoxCollider>();
            
            Input = new PlayerInput();
            Entity = new Entity(new Health(healthAmount));
        }
    }
}