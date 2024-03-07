using New.Enums;
using New.State_Machine;

namespace New.Test.States
{
    public abstract class TestBaseState : GenericBaseState<TestStatesEnum>
    {
        protected readonly TestStateMachine Context;

        protected TestBaseState(TestStatesEnum key, TestStateMachine context) : base(key)
        {
            Context = context;
        }
    
        public abstract override void CheckStateSwitch();
    }
}