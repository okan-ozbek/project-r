using Player.Component;
using Player.Enum;
using Player.State;
using StateMachine;
using UnityEngine;

namespace Player
{
    /*
     * TODO
     * **** Figure out a way to make the states not be so ugly.
     * **** See if I can refrain from using the override function for the monobehaviour classes.
     */ 
    
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
    public sealed class PlayerStateMachine : StateManager<PlayerStateEnum>
    {
        public float Speed => (Input.HasPressedSprint)
            ? runSpeed
            : walkSpeed;
        
        public float walkSpeed;
        public float runSpeed;
        
        public new Rigidbody rigidbody;
        public BoxCollider boxCollider;

        public PlayerInput Input;
        public PlayerMovement Movement;

        protected override void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            boxCollider = GetComponent<BoxCollider>();

            Input = new PlayerInput();
            Movement = new PlayerMovement(this);
            
            States.Add(PlayerStateEnum.Fall, new PlayerFall(this, PlayerStateEnum.Fall));
            States.Add(PlayerStateEnum.Grounded, new PlayerGrounded(this, PlayerStateEnum.Grounded));
            States.Add(PlayerStateEnum.Jump, new PlayerJump(this, PlayerStateEnum.Jump));

            CurrentState = States[PlayerStateEnum.Grounded];
            
            base.Start();
        }

        protected override void Update()
        {
            Input.Update();
            
            base.Update();
        }
        
        public bool OnGround()
        {
            var distanceToGround = boxCollider.bounds.extents.y;
            
            return Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);
        }
    }
}