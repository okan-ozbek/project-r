using System;

namespace State_Machine
{
    public abstract class GenericBaseState<TStates> where TStates : Enum
    {
        public TStates Key { get; }
    
        protected GenericBaseState(TStates key)
        {
            Key = key;
        }

        public virtual void OnEnter() { }

        public virtual void OnUpdate() { }
    
        public virtual void OnLeave() { }
        
        public void Update()
        {
            CheckStateSwitch();
            
            OnUpdate();
        }

        protected abstract void CheckStateSwitch();
    }
} 