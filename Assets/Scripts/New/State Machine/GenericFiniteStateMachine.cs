using System;
using System.Collections.Generic;
using UnityEngine;

namespace New.State_Machine
{
    public abstract class GenericFiniteStateMachine<TStates> : MonoBehaviour where TStates : Enum
    {
        private Dictionary<TStates, GenericBaseState<TStates>> _states = null!;
        private GenericBaseState<TStates> _currentState = null!;
    
        public void TransitionTo(TStates state)
        {
            if (state.Equals(_currentState.Key)) 
            {
                return;
            }

            _currentState.OnLeave();
            _currentState = _states[state];
            _currentState.OnEnter();
        }

        protected void SetStates(TStates defaultState)
        {
            _states = GetStates();

            _currentState = _states[defaultState];
            _currentState.OnEnter();
        }
    
        protected abstract Dictionary<TStates, GenericBaseState<TStates>> GetStates();
    }
}