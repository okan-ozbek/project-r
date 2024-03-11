using System;
using System.Collections.Generic;
using UnityEngine;

namespace State_Machine
{
    public abstract class GenericFiniteStateMachine<TStates> : MonoBehaviour where TStates : Enum
    {
        private Dictionary<TStates, GenericBaseState<TStates>> _states = null!;
        protected GenericBaseState<TStates> CurrentState { get; private set; }
    
        public void TransitionTo(TStates state)
        {
            if (state.Equals(CurrentState.Key)) 
            {
                return;
            }

            CurrentState.OnLeave();
            CurrentState = _states[state];
            CurrentState.OnEnter();
        }

        protected void SetStates(TStates defaultState)
        {
            _states = GetStates();

            CurrentState = _states[defaultState];
            CurrentState.OnEnter();
        }
    
        protected abstract Dictionary<TStates, GenericBaseState<TStates>> GetStates();
    }
}