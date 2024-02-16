using System;
using System.Collections.Generic;

namespace StateMachine
{
    public abstract class StateManager<TStates> where TStates : Enum
    {
        public Dictionary<TStates, BaseState<TStates>> States = new();
        public BaseState<TStates> CurrentState { get;  set; }

        private bool _isTransitioning;

        public void OnStateEnter()
        {
            CurrentState.OnStateEnter();
        }
        
        public void OnStateUpdate()
        {
            if (CanRunUpdate())
            {
                TStates newStateName = CurrentState.GetNewState();

                if (IsNewState(newStateName))
                {
                    TransitionTo(newStateName);
                }
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
            return (newStateName.Equals(CurrentState.Name) == false);
        }
    }
}