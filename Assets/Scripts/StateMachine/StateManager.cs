using System;
using System.Collections.Generic;
using Codice.CM.Common;
using UnityEngine;

namespace StateMachine
{
    public abstract class StateManager<TStates> : MonoBehaviour where TStates : Enum
    {
        protected readonly Dictionary<TStates, BaseState<TStates>> States = new();
        protected BaseState<TStates> CurrentState { get;  set; }

        private bool _isTransitioning;

        protected virtual void Start()
        {
            InitializeStates();
            
            CurrentState.OnStateEnter();
        }
        
        protected virtual void Update()
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
             
            CurrentState.OnStateUpdate();
        }

        protected void FixedUpdate()
        {
            CurrentState.OnStateFixedUpdate();
        }

        protected void OnTriggerEnter(Collider other)
        {
            CurrentState.OnStateTriggerEnter(other);
        }

        protected void OnCollisionEnter(Collision other)
        {
            CurrentState.OnStateCollisionEnter(other);
        }

        protected abstract void InitializeStates();
        
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