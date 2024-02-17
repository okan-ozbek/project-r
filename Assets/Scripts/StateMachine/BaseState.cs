using System;
using UnityEngine;

namespace StateMachine
{
    public abstract class BaseState<TStates> : IIBaseState<TStates> where TStates : Enum
    {
        public readonly TStates Name;
        
        protected BaseState(TStates name)
        {
            Name = name;
        }
        public virtual void OnStateEnter() {}
        public virtual void OnStateUpdate() {}
        public virtual void OnStateFixedUpdate() {}
        public virtual void OnStateLeave() {}
        public virtual void OnStateTriggerEnter(Collider other) {}
        public virtual void OnStateCollisionEnter(Collision other) {}

        public abstract TStates GetNewState();
    }
}