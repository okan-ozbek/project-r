using Player.Factories;
using Player.Interfaces;

namespace Player.States
{
    public abstract class BaseState : IIBaseState
    {
        protected BaseState CurrentState;
        protected PlayerContext Context;
        protected PlayerStateFactory Factory;

        protected BaseState(PlayerContext context, PlayerStateFactory factory)
        {
            Context = context;
            Factory = factory;
        }

        public void Init(BaseState state)
        {
            CurrentState = state;
            CurrentState.StateEnter();
        }
        
        public void Update()
        {
            StateUpdate();
            
            CheckStateTransitionable();
        }

        public void FixedUpdate()
        {
            StateFixedUpdate();
        }

        protected void TransitionTo(BaseState state)
        {
            CurrentState.StateLeave();
            CurrentState = state;
            CurrentState.StateEnter();
        }
        
        protected virtual void StateEnter() { }
        
        protected virtual void StateLeave() { }

        protected virtual void StateFixedUpdate() { }
        
        protected virtual void StateUpdate() { }

        protected abstract void CheckStateTransitionable();
        
        
    }
}