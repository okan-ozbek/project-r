using System;

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
        public virtual void OnStateLeave() {}

        public abstract TStates GetNewState();
    }
}