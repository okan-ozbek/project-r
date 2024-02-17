using System;
using System.Collections.Generic;

namespace StateMachine.Test
{
    public abstract class TestStateManager<TStates> where TStates : Enum
    {
        public readonly Dictionary<TStates, BaseState<TStates>> States = new();
        public BaseState<TStates> CurrentState { get; protected set; }

        private bool _isTransitioning;

        protected void Start()
        {
            CurrentState.OnStateEnter();
        }

        protected void Update()
        {
            if (!CanRunUpdate())
            {
                return;
            }
            
            var newStateName = CurrentState.GetNewState();

            if (IsNewState(newStateName))
            {
                TransitionTo(newStateName);
            }
        }

        private void TransitionTo(TStates stateName)
        {
            _isTransitioning = true;

            CurrentState.OnStateLeave();
            CurrentState = States[stateName];
            CurrentState.OnStateEnter();

            _isTransitioning = false;
        }

        private bool CanRunUpdate()
        {
            return (_isTransitioning == false);
        }

        private bool IsNewState(TStates newStateName)
        {
            return (newStateName.Equals(CurrentState.StateName) == false);
        }
    }
}