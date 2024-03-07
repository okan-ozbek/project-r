using System;

namespace New.State_Machine
{
    public abstract class GenericBaseState<TStates> where TStates : Enum
    {
        public TStates Key { get; }
    
        protected GenericBaseState(TStates key)
        {
            Key = key;
        }

        public virtual void OnEnter()
        {
            Console.WriteLine("Entered the {0} state.", Key);
        }

        public virtual void Update()
        {
            CheckStateSwitch();
        }
    
        public virtual void OnLeave()
        {
            Console.WriteLine("Entered the {0} state.", Key);
        }

        public abstract void CheckStateSwitch();
    }
} 